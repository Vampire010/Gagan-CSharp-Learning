Feature: BookAppointment

Make an  Appointment in Hongkong CURA Healthcare Center

@MakeAppointment
Scenario: Make an  Appointment 
	Given Login to Application
	Then Choose the facility
	Then Apply for hospital readmission
	Then Select the Healthcare Program
	Then Select Visit Date
	Then Enter the Comment
	Then Click on Book Appointment



