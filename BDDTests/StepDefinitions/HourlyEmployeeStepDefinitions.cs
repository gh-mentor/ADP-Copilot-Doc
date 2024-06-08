﻿/*
 * This file contains test methods for an Hourly Employee.
 * It uses the SpecFlow framework to define the steps for the test scenario.
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using PayrollLibrary;
using FluentAssertions;

namespace BDDTests.StepDefinitions
{
    [Binding]
    public class HourlyEmployeeSteps
    {
        private HourlyEmployee? _employee;
        private double? _payment;
        private string? _details;

        /*
         * Create a method 'GivenTheHourlyRateIs10'
         * Details:
         * This method creates a new instance of the HourlyEmployee class and sets the hourly rate to $10 and the number of hours worked to 0.
         * All constructor arguments except the hourly rate and hours worked are nullable and should be set to 'null'.
         * Example:
         * _employee = new HourlyEmployee(null, null, null, null, null, null, 10, 0);
         */
        [Given(@"the hourly rate is \$10")]
        public void GivenTheHourlyRateIs10()
        {
            _employee = new HourlyEmployee(null, null, null, null, null, null, 10, 0);
            // assert the employee instance is not null
            _employee.Should().NotBeNull();
            // assert the hourly rate is 10
            _employee!.HourlyRate.Should().Be(10);
        }

        /*
         * Create a method 'GivenTheNumberOfHoursWorkedIs40' that sets the number of hours worked to 40.
         * Details:
         * It creates a new HourlyEmployee object with the hourly rate set to 10 (from the previous step) and the number of hours worked set to 40
         */
        [Given(@"the number of hours worked is 40")]
        public void GivenTheNumberOfHoursWorkedIs40()
        {
            _employee = new HourlyEmployee(null, null, null, null, null, null, _employee!.HourlyRate, 40);

            // assertt the number of hours worked is 40
            _employee!.HoursWorked.Should().Be(40);
        }

        /*
         * This method 'WhenThePaymentIsCalculated' is a When step that calculates the payment for the employee.
         * Details:
         * It calls the Payment property of the employee object to calculate the payment.
         */
        [When(@"the payment is calculated")]
        public void WhenThePaymentIsCalculated()
        {
            _payment = _employee!.Payment;
        }


        /*
         * This method 'ThenThePaymentShouldBe400' is a When step that asserts that the payment is $400.
        */
        [Then(@"the payment should be \$400")]
        public void ThenThePaymentShouldBe400()
        {
            Assert.AreEqual(400, _payment);
        }

        /*
         * This method 'ThenTheEmployeeDetailsShouldBeDisplayed' is a then step that asserts that the employee details are displayed.
         * 
         */
        [Then(@"the employee details should be displayed")]
        public void ThenTheEmployeeDetailsShouldBeDisplayed()
        {
            _details = _employee!.ToString();
            Assert.IsNotNull(_details);
        }

    }
}