Feature: Submit a Clinical Trial for the Patient

  In order to serve the patient medically
  As a Doctor
  I want to be able to submit a clinical trial for the patient

  @Clinical
  Scenario Outline: Susan needs to submit a clinical trial 

    Given that I login to Clinical Trial Application with <UserName> and <Password>
	And she fills up the Trial details with <Sponsor> and <CoopGroup> and <RegoNumber> and <Phase> and <Group> and <TumourCategory> and <TumourGroup> and <Stage> and <Population> and <MultiCentre> and <Site> and <BioMarkerStudy> and <MolTarget>
	And she fills up the BioMarker section <TrialEligiblity> and <MolTarget> and <TissueAvailability>
	And she fills up the Trial Type
	And she fills up the Portfolio Inclusion
	And she fills up the Reporting Group
    When she submits the trial
    Then she should be shown with success message

	Examples: 
	| Test   | UserName        | Password    | Sponsor    | CoopGroup | RegoNumber  | Phase    | Group      | TumourCategory | TumourGroup | Stage     | Population | MultiCentre | Site                | BioMarkerStudy | MolTarget | TrialEligiblity | TissueAvailability |
	| Test01 | Emmanuel Russel | Welcome@123 | ACT Health | ANZMTG    | ANZ11780009 | Phase II | Adult      | Neurological   | Brain       | Regional  | 1. Cancer  | Yes         | Wollongong Hospital | Yes            | CEA       | Yes             | Yes                |
	| Test02 | Emmanuel Russel | Welcome@123 | Kosan      | CCLG      | ANZ11780010 | Phase Ia | Adolescent | Haematological | Leukaemia   | Localised | 3. Both    | Yes         | Nepean Hospital     | Yes            | HER2      | Yes             | Yes                |

			