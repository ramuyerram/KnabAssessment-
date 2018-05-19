Feature: SpecFlowFeature1
	

@mytag
Scenario: Validate Merk for validate License Plate
	Given When user logs into web  https://mijn-verzekeren.knab.nl/car/detail
	And sets the value for License plate to BR-TH-41	
	When Press tab key {TAB}
	Then the result should be Merk on the screen

	@mytag
Scenario: Validate Faslse retruend for INVALID License Plate
	Given When user logs into web  https://mijn-verzekeren.knab.nl/car/detail
	And sets the value for License plate to TD-TH-41	
	When Press tab key {TAB}
	Then the result should be False on the screen

	Scenario: Validate False retruend  When ONLY Numerics are provided for License Plate
	Given When user logs into web  https://mijn-verzekeren.knab.nl/car/detail
	And sets the value for License plate to 111111	
	When Press tab key {TAB}
	Then the result should be False on the screen

	Scenario: Validate False retruend When ONLY Characters are provided for License Plate
	Given When user logs into web  https://mijn-verzekeren.knab.nl/car/detail
	And sets the value for License plate to ABBBB	
	When Press tab key {TAB}
	Then the result should be False on the screen

	Scenario: Validate False retruend When null is provided for License Plate
	Given When user logs into web  https://mijn-verzekeren.knab.nl/car/detail
	And sets the value for License plate to ""	
	When Press tab key {TAB}
	Then the result should be False on the screen



