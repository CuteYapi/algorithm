/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/42583
 */
using System.Collections.Generic;
using System.Linq;

namespace TruckOnBridge
{
    public class Solution
    {
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int timeGone = 0;
            int truckCount = 0;

            Queue<Truck> truckQueue = new Queue<Truck>();

            Truck firstTruck = new Truck();
            firstTruck.weight = truck_weights[truckCount];
            truckQueue.Enqueue(firstTruck);

            while(truckQueue.Count > 0)
            {
                timeGone++;

                foreach (var item in truckQueue)
                {
                    item.currentPosition++;
                }

                if(truckQueue.Peek().currentPosition > bridge_length)
                {
                    truckQueue.Dequeue();
                }

                if(truckCount + 1 < truck_weights.Length &&
                    truckQueue.Sum(x => x.weight) + truck_weights[truckCount + 1] <= weight)
                {
                    truckCount++;

                    Truck newTruck = new Truck();
                    newTruck.weight = truck_weights[truckCount];
                    newTruck.currentPosition = 1;

                    truckQueue.Enqueue(newTruck);
                }
            }

            return timeGone;
        }

        public class Truck
        {
            public int weight;
            public int currentPosition = 0;
        }
    }
}
