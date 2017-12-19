# Common Dll Example

This is an example to test the sharing of a common .net dll between a Rhino Plugin .rhp and a Grasshopper Add-On .gha.
The common dll just has one class that returns a string of the current time.

The .sln contains all three .csproj files. The Grasshopper Add-On project bas a post-build event to copy the .gha to the same folder as the Rhino .rhp.

To test, start debugging (launches Rhino 6 BETA at the time of writing) and drag and drop the .rhp into Rhino (do this the first time).
Running the _Grasshopper command will show that the .gha is loaded from the location of the .rhp file.

Developed with Visual Studio 2017, Rhino 6 BETA. All projects .net Framework 4.5.

Rhino Plugin and Grasshopper Add-On based on the [templates provided by McNeel](https://marketplace.visualstudio.com/search?term=publisher%3A%22McNeel%22&target=VS&category=All%20categories&vsVersion=&sortBy=Relevance).