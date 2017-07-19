Feature: Dashboard

@Clinical
  Scenario Outline: Susan needs to view the dashboard

  Given that I login to Clinical Trial Application with <user> and <password>
  And I select the <hospital>
  Then I should see the dashboard of the selected hospital

  Examples: 
  | user            | password    | hospital          |
  | Emmanuel Russel | Welcome@123 | Canberra Hospital |