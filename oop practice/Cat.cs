using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{
    class Dog
    {
        //Declare Fields
        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;
        private string name;
        //Declare Properties
        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }

        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }

        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
            
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        //Declare constructors
        public Dog()
        {
        }
        public Dog(int hairLength, int runningSpeed, int weight, string name)
        {
            this.hairLength = hairLength;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
            this.name = name;
        }


       
       

        
    }       
        

            


    





    class Cat
    {
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Cat()
        {

        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
    }
}
