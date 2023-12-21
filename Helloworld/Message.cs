using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Helloworld
{
    internal class Message
    {
        
        private String _message;
        private double _hMorning;
        private double _hMidday;
        private double _hAfternoon;
        public string _HelloMessage
        {
            get => _message;
            set => _message = value;
        }
        public Message(double p_hMorning, double p_hMidday, double p_hAfternoon) { 
            _hMorning = p_hMorning;
            _hMidday = p_hMidday;
            _hAfternoon = p_hAfternoon;
        }

        public void SetMessage()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            if (DateTime.Now.Hour >= _hMorning && DateTime.Now.Hour < _hMidday && DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                _HelloMessage = ("Bonjour " + userName);
            }
            else if (DateTime.Now.Hour >= _hMidday && DateTime.Now.Hour < _hAfternoon && DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                _HelloMessage = ("Bon après-midi " + userName);
            }
            else if ((DateTime.Now.Hour >= _hAfternoon || DateTime.Now.Hour < _hMorning) && (DateTime.Now.DayOfWeek != DayOfWeek.Friday | DateTime.Now.DayOfWeek != DayOfWeek.Saturday || DateTime.Now.DayOfWeek != DayOfWeek.Sunday))
            {
                _HelloMessage = ("Bonsoir " + userName);
            }
            else if ((DateTime.Now.Hour >= _hAfternoon || DateTime.Now.Hour < _hMorning) && (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday))
            {
                _HelloMessage = ("Bon Week-End " + userName);
            }
        }
    }
}
