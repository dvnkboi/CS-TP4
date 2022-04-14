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
    - `IDbConnection con`  
    - `IDbConnection cmd`
  - functions:
    - `Connect()` opens connection to given database server using connection string
      - **parameters**
        - ` string cstr` connection string to connect with
        - ` string server` database server type to connect to, currently supported: MySql MsSql
      - **Returns**
        - ` void`
    
    
    - `IUD()` executes an insert/update/delete query
      - **parameters**
        - ` string req` request to execute
      - **Returns**
        - `int` number of lines affected


    - `Select()` executes a select query
      - **parameters**
        - ` string req` request to execute
      - **Returns**
        - `IDataReader` dataReader containing the result rows


    - `GetTableFields()` gets the table fields and their types of a selected table
      - **parameters**
        - ` string table` table to get the fields for
      - **Returns**
        - `Dictionary<string,string>` Dictionary containing field names as keys and their types as values


    - `AddParameter()` sets command type to stored procedure and adds parameter to it
      - **parameters**
        - ` string key` key of parameter to add 
        - ` Object value` value to set to the parameter
      - **Returns**
        - `void`

    - `ResetCmd()` resets command text, type and parameter array
      - **parameters**
        - ` none`
      - **Returns**
        - `void`
    
    - `Close()` Closes connection to db
      - **parameters**
        - ` none`
      - **Returns**
        - `void`


#### Model
inheritable abstract class that implements basic crud operations, and allows casting to a target class.
*all database operations are done on a table with the same name as the current class example:`Students`*.  
  - properties:
    - `int id`
    - `string sql`
  - functions:
    - `save()` saves the object to the database using stocked procedures, and falling back to sql if no stored procedure is found
      - **parameters**
        - ` string procedure`*(optional)* name of the procedure to use for update/insert
      - **Returns**
        - `int` number of lines affected
    
    
    - `find()` retrieves the current instance from the database using the id property
      - **parameters**
        - ` none`
      - **Returns**
        - `Object` result of the find query, castable to the current class
    - `find<T>()` retrieves the current instance from the database using the id property
      - **parameters**
        - ` object id` primary key of element to find, castable to calling class 
      - **Returns**
        - `Object` result of the find query, castable to the current class


    - `delete()` deletes the current instance from the database using the id property
      - **parameters**
        - ` string procedure`*(optional)* name of the procedure to use for delete 
      - **Returns**
        - `int` number of lines affected


    - `All()` retrieves all objects from the table
      - **parameters**
        - ` none` 
      - **Returns**
        - `List<dynamic>` list of objects found cast to the current class


    - `All<T>()` static method that retrieves all objects from the table
      - **parameters**
        - ` none` 
      - **Returns**
        - `List<dynamic>` list of objects found cast to the Template class given


    - `Select()` retrieves Select objects from the table using criteria
      - **parameters**
        - ` Dictionary<string,object> criteria` criteria to use for the select query example:`{ "id" : 1 }`
      - **Returns**
        - `List<dynamic>` list of objects found cast to the current class


    - `Select<T>()` static method that retrieves Select objects from the table using criteria
      - **parameters**
        - ` Dictionary<string,object> criteria` criteria to use for the select query example:`{ "id" : 1 }`
      - **Returns**
        - `List<dynamic>` list of objects found cast to the Template class given
    
    - `ObjectToDictionary<T>()` method that converts an object to a Dictionary
      - **parameters**
        - ` Object obj` object to convert to a dictionary
      - **Returns**
        - `Dictionary<string, T>` dictionary of the object properties


    - `DictionaryToObject()` method that converts a dictionary to an object
      - **parameters**
        - ` Dictionary<string,object> dico` dictionary to convert to an object
      - **Returns**
        - ` Object` object with the current class type created from the dictionary


    - `DictionaryToObject<T>()` static method that converts a dictionary to an object
      - **parameters**
        - ` Dictionary<string,object> dico` dictionary to convert to an object
      - **Returns**
        - ` Object` object with the Template class type created from the dictionary

    - `SqlToType()` method that converts a sql type to a C# type
      - **parameters**
        - ` string type` sql type to convert to a C# type
      - **Returns**
        - ` Type` C# type
---
## GUI app
this is a demo app using the methods provided in the model library to preview a functional application with students, their classes and test marks.
