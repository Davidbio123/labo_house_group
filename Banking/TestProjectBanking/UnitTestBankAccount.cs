using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectBanking
{
    [TestClass]
    public class UnitTestBankAccount
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDepositNegativeAmount()
        {
            //Arangement
            BankAccount ba = new BankAccount();
            //action
            ba.Deposit(-5000);
            //Assert
        }
        [TestMethod]
        public void TestDepositPositiveAmount()
        {
            //Arangement
            BankAccount ba = new BankAccount();
            decimal expectedBalance = 5000;
            decimal expectedBalanceDeposit2 = 7000;
            //Action
            decimal newBalance = ba.Deposit(5000);
            //Assert affirmation
            Assert.AreEqual(expectedBalance, newBalance, "Depot 1");
            newBalance = ba.Deposit(2000);
            Assert.AreEqual(expectedBalanceDeposit2, newBalance, "Depot 2");   
        }
        [TestMethod]
        public void TestWithdrawAccepted()
        {
            //Arangement
            BankAccount ba = new BankAccount();
            decimal expectedBalance = 5000;
            bool expectedResult = true;
            //Action
            ba.Deposit(7000);
            bool result = ba.Withdraw(2000);
            //Assert affirmaiton
            Assert.AreEqual(expectedBalance, ba.GetBalance());
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestWithdrawRejected()
        {
            //Arangement
            BankAccount ba = new BankAccount();
            decimal expectedBalance = 5000;
            bool expectedResult = false;
            //Action
            ba.Deposit(5000);
            bool result = ba.Withdraw(5001);
            //Assert affirmaiton
            Assert.AreEqual(expectedBalance, ba.GetBalance());
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestNationalRegisterLength()
        {
            //Arangement
            NationalRegister nr = new NationalRegister();
            string expectedRegisterNumber = "12345678911";
            int eleven = 11;
            //Action
            nr.RegisterNumber = expectedRegisterNumber;
            string expectedValue = nr.RegisterNumber;
            //Assert affirmation
            Assert.AreEqual(expectedValue.Length, eleven);
        }
        [TestMethod]
        public void TestNationalRegisterOverLength()
        {
            //Arangement
            NationalRegister nr = new NationalRegister();
            string expectedRegisterNumber = "123456789111";
            bool expectedResult = false;
            //Action
            nr.RegisterNumber = expectedRegisterNumber;
            string expectedValue = nr.RegisterNumber;
            nr.RegisterNumber = expectedRegisterNumber;
            int size = expectedValue.Length;
            bool result = nr.TestLength(size);
            //Assert affirmation
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestNationalRegisterDateYear()
        {
            //Arangement
            NationalRegister myBirthYear = new NationalRegister();
            int year = 78;
            myBirthYear.DateRegisterYear = 780429;
            DateTime myDate = new DateTime();
            //Action
            try
            {
                myDate.AddYears(myBirthYear.DateRegisterYear);
            }
            catch(Exception)
            {
                
            }
            //Assert affirmation
            Assert.AreEqual(myBirthYear.DateRegisterYear, year);
        }
        [TestMethod]
        public void TestNationalRegisterDateWrongYear()
        {
            //Arangement
            NationalRegister myBirthYear = new NationalRegister();
            int year = 79;
            myBirthYear.DateRegisterYear = 780429;
            DateTime myDate = new DateTime();
            bool testing = true;
            bool testYear = false;
            //Action
            try
            {
                myDate.AddYears(myBirthYear.DateRegisterYear);
                if (year != myBirthYear.DateRegisterYear)
                {
                    testing = false;
                }
            }
            catch (Exception)
            {
                testing = false;
            }
            //Assert affirmation
            Assert.AreEqual(testing, testYear);
        }
        [TestMethod]
        public void TestNationalRegisterDateMonth()
        {
            //Arangement
            NationalRegister myBirthMonth = new NationalRegister();
            int month = 04;
            myBirthMonth.DateRegisterMonth = 780429;
            DateTime myDate = new DateTime();
            //Action
            try
            {
                myDate.AddMonths(myBirthMonth.DateRegisterMonth);
            }
            catch (Exception)
            {

            }
            //Assert affirmation
            Assert.AreEqual(myBirthMonth.DateRegisterMonth, month);
        }
        [TestMethod]
        public void TestNationalRegisterDateWrongMonth()
        {
            //Arangement
            NationalRegister myBirthMonth = new NationalRegister();
            int month = 05;
            myBirthMonth.DateRegisterDay = 780429;
            DateTime myDate = new DateTime();
            bool testing = true;
            bool testMonth = false;
            //Action
            try
            {
                myDate.AddMonths(myBirthMonth.DateRegisterYear);
                if (month != myBirthMonth.DateRegisterYear)
                {
                    testing = false;
                }
            }
            catch (Exception)
            {
                testing = false;
            }
            //Assert affirmation
            Assert.AreEqual(testing, testMonth);
        }
        [TestMethod]
        public void TestNationalRegisterDateDay()
        {
            //Arangement
            NationalRegister myBirthDay = new NationalRegister();
            int day = 29;
            myBirthDay.DateRegisterDay = 780429;
            DateTime myDate = new DateTime();
            //Action
            try
            {
                myDate.AddDays(myBirthDay.DateRegisterDay);
            }
            catch (Exception)
            {

            }
            //Assert affirmation
            Assert.AreEqual(myBirthDay.DateRegisterDay, day);
        }
        [TestMethod]
        public void TestNationalRegisterDateWrongDay()
        {
            //Arangement
            NationalRegister myBirthDay = new NationalRegister();
            int month = 05;
            myBirthDay.DateRegisterDay = 780429;
            DateTime myDate = new DateTime();
            bool testing = true;
            bool testDay = false;
            //Action
            try
            {
                myDate.AddDays(myBirthDay.DateRegisterDay);
                if (month != myBirthDay.DateRegisterDay)
                {
                    testing = false;
                }
            }
            catch (Exception)
            {
                testing = false;
            }
            //Assert affirmation
            Assert.AreEqual(testing, testDay);
        }
        [TestMethod]
        public void TestNationalRegisterLastTwoDigit()
        {
            //Arangement
            NationalRegister myTwoLastRegisterDigit = new NationalRegister();
            int twoLastDigit = 22;
            myTwoLastRegisterDigit.TwoLastRegisterDigit = "78042933322";
            DateTime myDate = new DateTime();
            //Action

            //Assert affirmation
            Assert.AreEqual(myTwoLastRegisterDigit.DateRegisterDay, twoLastDigit);
        }

    }
}
