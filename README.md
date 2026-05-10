# ScientistPlatform

ScientistPlatform is a Windows Forms application for storing, searching and analyzing scientific articles.

## Project structure

The solution contains two projects:

- `ScientistPlatform` — Windows Forms user interface.
- `Model` — class library with business logic.

The `Model` project contains:

- `Core` — domain classes: `Author`, `Article`, `ResearchArticle`, `ReviewArticle`, `CaseStudy`, `Publisher`, `ArticleRepository`, `SearchService`.
- `Data` — serialization classes for JSON and XML.

## Main window

The main window contains a table with scientific articles and controls for searching, publishing and changing the data format.

### Search criterion

A drop-down list where the user selects the property used for search:

- ISSN
- Title
- Year
- JournalName
- KeyWords
- ArticleType
- Authors
- Publisher

### Search value

A text field where the user enters the search value.

### Find articles button

The button becomes active only when the search criterion is selected and the search value is not empty.

After pressing the button, matching articles are displayed in the table.

### Articles table

The table displays:

- ISSN
- Title
- Year
- JournalName
- Article type
- Keywords
- Authors
- Publisher

### Publishers list

A list of available publishers. Each publisher has a name, rating and list of topics.

### Article ISSN field

The user enters the ISSN of the article that should be sent to the selected publisher.

### Send to publisher button

Sends the article to the selected publisher.

The article can be sent only if at least one article keyword matches at least one publisher topic.

If the article is not found or does not match the publisher topics, an error message is shown.

### Data format list

A drop-down list for choosing the storage format:

- Json
- Xml

When the user changes the format, the application loads data from the current format and saves the same data in the new format.

### Create citation button

Opens the citation window.

## Citation window

The citation window contains:

### Article list

The user selects an article.

### Publisher list

The user selects a publisher.

### Create citation button

Creates a citation string for the selected article and publisher.

Citation format depends on the selected publisher rating.

### Citation field

Displays the generated citation.

### Save citation button

Saves the generated citation to a `.txt` file.

## Initial data

At the first launch, the application creates default articles and publishers automatically.

Default articles:

1. `Machine Learning in Medicine` — ResearchArticle
2. `Modern Climate Models Review` — ReviewArticle
3. `Rare Disease Treatment Case` — CaseStudy
4. `Robotics in Industrial Engineering` — ResearchArticle

Default publishers:

1. `Science House`
2. `Eco Publishing`
3. `Case Reports Ltd`
4. `Engineering Press`

## Data files

The application stores article data in the `Data` folder.

Supported formats:

- `articles.json`
- `articles.xml`

## How to run

1. Open `ScientistPlatformSolution.sln` in Visual Studio.
2. Set `ScientistPlatform` as the startup project.
3. Build the solution.
4. Run the application.
