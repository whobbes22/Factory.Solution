# _The Factory_

#### By _**Joseph Wahbeh**_

#### Project implements C# to a place to Engineers and Machines to be worked on.

## Technologies Used

* _C#_
* _Microsoft.NET.Sdk v6.0_
* _MySQL WorkBench v8.0_

## Description

_This is a web page application that allows a user to store information about engineers and machines. The user can assign machines and engineers to each other to be worked. An engineer can work on multiple machines, and machines can be worked on by multiple engineers._

## Setup/Installation Requirements

* _Clone `Factory.Solution` from the repository to desired location_
* _Navigate to cloned directory via your local terminal command line_
* _Navigate to this project's production directory called `Factory` through the terminal_.
* _In the terminal, run the command `touch appsettings.json` and open the file using the command `code appsettings.json`_ 


* _Copy and paste the follwing code into the `appsettings.json` file_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=the_greatest_factory_known_to_man_kind;uid=[user-id-Name];pwd=[user-password];"
  } 
}
```
* _Replace `[user-id-Name]`, `[user-password]` Brackets included with the corresponding information_
* _Save and exit `appsettings.json`_

* _In the terminal, run the command `dotnet ef migrations add InitialFactory`_
* _In the terminal, run the command `dotnet ef database update`_
* _In the terminal, run the command `dotnet watch run`_

## Known Bugs

* _No known bugs as of 5/26/23_

## License
MIT License

Copyright (c) 2023 Joseph Wahbeh

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
