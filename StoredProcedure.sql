create database EmployeePayrollMVC

use EmployeePayrollMVC

Create table EmployeeTable(        
    EmployeeId int IDENTITY(1,1) Primary Key(EmployeeId),        
    EmployeeName varchar(100),        
    Profile varchar(50),        
    Gender varchar(20),        
    Dept varchar(50),
    Salary varchar(100),
    StartDate Date
);

select * from EmployeeTable

Create procedure AddEmployeeSP         
(        
    @EmployeeName VARCHAR(100),         
    @Profile VARCHAR(50),        
    @Gender VARCHAR(20),        
    @Dept VARCHAR(50) ,
    @Salary VARCHAR(100),        
    @StartDate Date
)        
as         
Begin         
    Insert into EmployeeTable (EmployeeName, Profile, Gender, Dept, Salary, StartDate)         
    Values (@EmployeeName,@Profile,@Gender, @Dept, @Salary, @StartDate)         
End


Create procedure UpdateEmployeeSP          
(          
   @EmployeeId INTEGER ,        
   @EmpName VARCHAR(100),         
   @Profile VARCHAR(50),        
   @Gender VARCHAR(20),        
   @Dept VARCHAR(50),
   @Salary VARCHAR(100),
   @StartDate Date
)          
as          
begin          
   Update EmployeeTable           
   set EmployeeName=@EmpName,          
   Profile=@Profile,          
   Gender=@Gender,        
   Dept=@Dept,
   Salary=@Salary,
   StartDate=@StartDate
   where EmployeeId=@EmployeeId          
End

Create procedure DeleteEmployeeSP         
(          
   @EmployeeId int          
)          
as           
begin          
   Delete from EmployeeTable where EmployeeId=@EmployeeId          
End

Create procedure GetAllEmployeesSP      
as      
Begin      
    select * from EmployeeTable      
End
