using System.IO.Ports;
using System.Security.Cryptography.X509Certificates;
using System;
namespace chexNS
{
    class Computer
    {
        public bool power = false;
        public int serialNumber = 0;
        public bool activationStatus = false;
        public bool PowerOn()
        {
            if (power == false)
            {
                power = true;
            }
            else
            {
                power = false;
            }

        }
        public int SetSerialNumber()
        {
            if (serialNumber == 0)
            {
                return serialNumber += 1;
            }

        }
        public Computer()
        {
            serialNumber = SetSerialNumber;
        }
    }
    class Laptop
    {
        public bool lidOpen = false;
        public int batteryCharge = 100;
        public readonly string mfgr;

        public bool lidStatus()
        {
            if (lidOpen == false)
            {
                base(power) = false;
            }
            else
            {
                base(power) = true;
            }
        }
        public bool lidOpenOrClose() 
        {
            if (lidOpen == false)
            {
                lidOpen = true;
                power = true;
            }    
            else
            {
                lidOpen = false;
                power = false;
            }
        }
        public Laptop(string mfgr, int serialNumber) : base(serialNumber)
            {
            mfgr = "GateWay";
        }
    }

        
    class SmartPhone
    {
        public int age;
        public readonly string mfgr;
        public readonly bool inToilet = false;
        public string headPhoneSocket = "alive";
        public readonly DropInToilet(bool inToilet, bool power) : base(power)
        {
            if (inToilet == true && power == true)
            {
                headPhoneSocket = "dead";
            }
        }
    }
    
}