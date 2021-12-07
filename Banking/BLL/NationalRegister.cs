using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NationalRegister
    {
        private string m_RegisterNumber;

        public string RegisterNumber
        {
            get => m_RegisterNumber;

            set
            {
                m_RegisterNumber = value;
            }
        }

        private int m_DateRegisterYear;
        public int DateRegisterYear
        {
            get { return m_DateRegisterYear; }
            
            set
            {
                m_DateRegisterYear = value;
                string strDateRegister = m_DateRegisterYear.ToString();         
                int year = int.Parse(strDateRegister.Substring(0, 2)); 
                m_DateRegisterYear = year;
            }
        }
 
        private int m_DateRegisterMonth;
        public int DateRegisterMonth
        {
            get { return m_DateRegisterMonth; }

            set
            {
                m_DateRegisterMonth = value;
                string strDateRegister = m_DateRegisterMonth.ToString();
                int month = int.Parse(strDateRegister.Substring(2, 2));// 78042925651
                m_DateRegisterMonth = month;
            }
        }
        private int m_DateRegisterDay;
        public int DateRegisterDay
        {
            get { return m_DateRegisterDay; }

            set
            {
                m_DateRegisterDay = value;
                string strDateRegister = m_DateRegisterDay.ToString();
                int month = int.Parse(strDateRegister.Substring(4, 2));
                m_DateRegisterDay = month;
            }
        }

        // 78042933322 long     22 int

        private string m_TwoLastRegisterDigit;

        public string TwoLastRegisterDigit
        {
            get
            {
                return m_TwoLastRegisterDigit;
            }
            set
            {
                
                string strTwoLastRegisterDigit = m_TwoLastRegisterDigit.ToString();
                m_TwoLastRegisterDigit = strTwoLastRegisterDigit.Substring(9, 2);
            }
        }

        public bool TestLength(int size)
        {
            if (size != 11)
            { 
               return false;
            }
            else
            {
                return true;
            }
        }
    }
}
