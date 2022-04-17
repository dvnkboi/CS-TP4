# CS TP4
this project implements a db connection library, console test for it, and student management GUI app using it.

## Console App
this is the console app that tests all methods in the model library using the Eleve table in a database called csharp

---
 
## ModelApp
this is the connection library, can connect to MsSql and MySql databases

### Classes:
#### Connection 
Library that handles Connection to MySql and MsSql databases
  - properties:
    - `IDbConnection con` internal connection to database
    - `IDbConnection cmd` internal command to execute
    - `string Server` current server used 
    - `string ConString` current connection string used
    - `Dictionnary<string,Dictionnary<string,string>> _SchemaMap` internal table field cache
    - `IsConnected` getter for current connection state


  - functions:
    - `static Connect()` opens connection to given database server using connection string
      - **parameters**
        - ` string cstr` connection string to connect with
        - ` string server` database server type to connect to, currently supported: MySql MsSql
      - **Returns**
        - ` void`
    
    
    - `static IUD()` executes an insert/update/delete query
      - **parameters**
        - ` string req` request to execute
      - **Returns**
        - `int` number of lines affected
     
     
    - `static Execute()` executes an sql string
      - **parameters**
        - ` string text` sql text to execute, this method is useful when trying to programatically create triggers, procedures ... 
      - **Returns**
        - `void`


    - `static Select()` executes a select query
      - **parameters**
        - ` string req` request to execute
      - **Returns**
        - `IDataReader` dataReader containing the result rows


    - `static GetTableFields()` gets the table fields and their types of a selected table
      - **parameters**
        - ` string table` table to get the fields for
      - **Returns**
        - `Dictionary<string,string>` Dictionary containing field names as keys and their types as values


    - `static AddParameter()` sets command type to stored procedure and adds parameter to it
      - **parameters**
        - ` string key` key of parameter to add 
        - ` Object value` value to set to the parameter
      - **Returns**
        - `void`


    - `static ResetCmd()` resets command text, type and parameter array
      - **parameters**
        - ` none`
      - **Returns**
        - `void`
    

    - `static Close()` Closes connection to db
      - **parameters**
        - ` none`
      - **Returns**
        - `void`


    - `static DatabaseProvided()` returns whether connection string contains a database
      - **parameters**
        - ` string conString` connection string to parse
        - ` string server` database server type
      - **Returns**
        - `bool` whether database exists in connection string


    - `static CreateDb()` creates a database in the DMBS with given name 
      - **parameters**
        - ` string conString` connection string to parse
        - ` string server` database server type
        - ` string db` database name to create
      - **Returns**
        - `void`


    - `static ConcatDb()` concatenates database name to connection string
      - **parameters**
        - ` string conString` connection string to parse
        - ` string server` database server type
        - ` string db` database name to create
      - **Returns**
        - `void`


    - `static ConcatStr()` concatenates connection string parameters
      - **parameters**
        - ` string host` host of the db connection
        - ` string server` database server type
        - ` string user=null` *(optional)* username to connect with, can be null or "" (in case using intergated security)
        - ` string pass=null` *(optional)* password to connect with, can be null or ""
        - ` string db=null` *(optional)* database to use, can be null
        - ` string[] opt` *(optional)* parameter array (example: `integrated security=True`)
      - **Returns**
        - `string` connection string


#### Model
inheritable abstract class that implements basic crud operations, and allows casting to the child class.  
example: `Student s = (Student)Student.find<Student>(id);`  
*all database operations are done on a table with the same name as the current class example:`Students`*.  
  - properties:
    - `int id`
    - `string sql`
  - functions:
    - `Save()` saves the object to the database using stocked procedures, and falling back to sql if no stored procedure is found
      - **parameters**
        - ` string procedure`*(optional)* name of the procedure to use for update/insert
      - **Returns**
        - `int` number of lines affected
    
    
    - `Find()` retrieves the current instance from the database using the id property
      - **parameters**
        - ` none`
      - **Returns**
        - `Object` result of the find query, castable to the current class
    - `static Find<T>()` retrieves the current instance from the database using the id property
      - **parameters**
        - ` object id` primary key of element to find, castable to calling class 
      - **Returns**
        - `Object` result of the find query, castable to the current class


    - `Delete()` deletes the current instance from the database using the id property
      - **parameters**
        - ` string procedure`*(optional)* name of the procedure to use for delete 
      - **Returns**
        - `int` number of lines affected


    - `All()` retrieves all objects from the table
      - **parameters**
        - ` none` 
      - **Returns**
        - `List<dynamic>` list of objects found cast to the current class


    - `static All<T>()` static method that retrieves all objects from the table
      - **parameters**
        - ` none` 
      - **Returns**
        - `List<dynamic>` list of objects found cast to the Template class given


    - `Select()` retrieves Select objects from the table using criteria
      - **parameters**
        - ` Dictionary<string,object> criteria` criteria to use for the select query example:`{ "id" : 1 }`
      - **Returns**
        - `List<dynamic>` list of objects found cast to the current class


    - `static Select<T>()` static method that retrieves Select objects from the table using criteria
      - **parameters**
        - ` Dictionary<string,object> criteria` criteria to use for the select query example:`{ "id" : 1 }`
      - **Returns**
        - `List<dynamic>` list of objects found cast to the Template class given
    
    - `static ObjectToDictionary<T>()` method that converts an object to a Dictionary
      - **parameters**
        - ` Object obj` object to convert to a dictionary
      - **Returns**
        - `Dictionary<string, T>` dictionary of the object properties


    - `DictionaryToObject()` method that converts a dictionary to an object
      - **parameters**
        - ` Dictionary<string,object> dico` dictionary to convert to an object
      - **Returns**
        - ` Object` object with the current class type created from the dictionary


    - `static DictionaryToObject<T>()` static method that converts a dictionary to an object
      - **parameters**
        - ` Dictionary<string,object> dico` dictionary to convert to an object
      - **Returns**
        - ` Object` object with the Template class type created from the dictionary


    - `static SqlToType()` method that converts a sql type to a C# type
      - **parameters**
        - ` string type` sql type to convert to a C# type
      - **Returns**
        - ` Type` C# type

#### ConvEngine
A conversion class that is able to convert generic collections to data to different file outputs
example:  
`List<Etudiant> e = Etudiant.All<Etudiant>();`  
`ConvEngine.CreateXLS<Etudiant>(e, "C:\etudiants.xlsx")`  
  - functions:
    - `static CreateCsv<T>()` creates CSV of the given List to the given file path
      - **parameters**
        - ` List<T> list` generic list of items to parse
        - ` string procedure` filepath to write to
      - **Returns**
        - `void`
    
    - `static CreateXLS<T>()` creates XLSX of the given List to the given file path
      - **parameters**
        - ` List<T> list` generic list of items to parse
        - ` string procedure` filepath to write to
      - **Returns**
        - `void`
    
---
## GUI app
this is a demo app using the methods provided in the model library to preview a functional application with students, their classes and test marks.
