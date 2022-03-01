Feature: ParaBankRequestLoan
    As a ParaBank client
    I want to be able to apply for a loan
    So I can temporarily increase my balance

    Scenario: Loan application is approved
    Given John wants to apply for a loan
    When he submits the following loan request
        | loanAmount | downPayment | accountNo |
        | 1000       | 100         | 12345     |
    Then the loan application is approved

    Scenario: Loan application is denied
    Given John wants to apply for a loan
    When he submits the following loan request
        | loanAmount | downPayment | accountNo |
        | 100000     | 100         | 12345     |
    Then the loan application is denied