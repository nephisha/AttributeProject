Feature: Submit a Clinical Trial for the Patient

  In order to serve the patient medically
  As a Doctor
  I want to be able to submit a clinical trial for the patient

  @Clinical
  Scenario Outline: Susan needs to submit a clinical trial 

    Given that I login to Clinical Trial Application with <UserName> and <Password>
	And she fills up the Trial details 
	And she fills up the BioMarker section
	And she fills up the Trial Type
	And she fills up the Portfolio Inclusion
	And she fills up the Reporting Group
    When she submits the trial
    Then she should be shown with success message

	Examples: 
	| UserName        | Password    | Hospital          |
	| Emmanuel Russel | Welcome@123 | Canberra Hospital |