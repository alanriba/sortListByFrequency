# sorteListByFrequency
Corresponds to the API that returns a string sorted by repetition frequency.

## Start 🚀
These instructions will allow you to get a copy of the project running on your local machine for development and testing purposes.

### Prerequisites 📋
The following software must be pre-installed on the PC.

  - [Microsoft Visual Studio Community 2019](https://visualstudio.microsoft.com/es/vs/community/) - Source code editor.
  
  
### Download Repository
```shell
eject git clone https://github.com/libgit2/libgit2 mylibgit
```

### Execution
1. Run Visual Studio 2019.
2. Select Open Project or a Solution.
3. Browse to project directory and load file with extension **.sln** .
4. The port with which the application will be executed must be configured. To do this, in the _Solution Explorer_ window, select the object Encora_ and right click and then _Properties_. 
   Select _Debug_ and in option _Application URL_ add the necessary address(es) separated with semicolon (;). In this case, ports **5000** are set.
    
   Or you can configure the property file launchsettings.json
    
```json
{
  "profiles": {
    "Encora": {
      "commandName": "Project",
      "launchBrowser": true,
      "applicationUrl": "http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
```

### Compilation 📦
To compile the project, it can be done from the menu _Compile > Compile Solution_ or _Recompile Solution_.

### Despliegue
Each time the application needs to be started, just execute from menu _Debug > Start debugging_ or _Start without debugging_.

### Local Test
For local testing you can use Swagger's graphical interface

```url
http://localhost:5000/swagger/index.html
```

![image](https://user-images.githubusercontent.com/25330708/191762914-6e2aabce-fc8f-4d42-bb9f-3bf24cf2453b.png)

or using the explorator 
http://localhost:5000/api/Home/sorted?param=abaccadcc

![image](https://user-images.githubusercontent.com/25330708/191767436-904c7682-85fa-4ec9-8314-ef4cb87d0b83.png)


### Unit Test
![image](https://user-images.githubusercontent.com/25330708/191766824-7c3b22d3-7ee3-4333-ad71-0eef6b130242.png)


    
