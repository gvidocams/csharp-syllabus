using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        List<Video> inventory;

        public VideoStore()
        {
            inventory = new List<Video>();
        }

        public void AddVideo(string title)
        {
            inventory.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            for(int i = 0; i < inventory.Count; i++)
            {
                if(inventory[i].title == title)
                {
                    inventory[i].BeingCheckedOut();
                    return;
                }
            }
        }

        public void ReturnVideo(string title)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].title == title)
                {
                    inventory[i].BeingReturned();
                    return;
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].title == title)
                {
                    inventory[i].ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach(Video video in inventory)
            {
                Console.WriteLine(video.ToString());
            }
        }
    }
}
