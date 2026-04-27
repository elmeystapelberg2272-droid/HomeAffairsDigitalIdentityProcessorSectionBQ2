# Digital Identity Processor
**Project Name:** HomeAffairsDigitalIdentityProcessorSectionBQ2
**Module:** SDT621 - Formative Assessment 1 (Section B Q2)

## Project Description
A professional Windows Forms application developed to validate South African Identity Numbers and generate comprehensive citizen profiles. This tool automates age calculation and citizenship verification based on ID metadata.

## Features
- **ID Validation**: Strictly validates the 13-digit identity string to ensure data integrity.
- **Automated Age Logic**: Extracts the birth date from the ID and calculates the citizen's age, correctly handling the "Year 2000" date rollover.
- **Encapsulated Profile**: Uses a `CitizenProfile` class with private setters to ensure that calculated data (like Age) cannot be manually tampered with.
- **GUI UX**: Features a user-friendly interface with read-only output fields and a clear "Process" workflow.

## Technical Details
- **Learning Outcomes**: Covers LO6 (Encapsulation), LO7 (Event-driven programming), and LO10 (GUI principles).
- **Tools Used**: C#, WinForms Framework, .NET 8.0.
