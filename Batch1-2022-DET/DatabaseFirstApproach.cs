using Batch1_2022_DET.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class DatabaseFirstApproach
    {
        private const string Sql = $"GetEmpsDetails";

        static void Main(string[] args)
        {
            //GetAllEmpDetails();
            // GetEmpDetailByID();
            //AddNewEmployee();
            //RemoveNewEmployee();

            //UpdateEmployeeWParam();


            //UpdateEmployeeWOParam();
            CallStoredProcwithSQLParamater_insert();

            Console.ReadLine();
        }

        private static void UpdateNewEmployee()
        {
            var ctx = new ThanmayContext();
            var employee = ctx.Emps.Where(e => e.Empno == 2300).SingleOrDefault();
            try
            {

                Emp employee1 = new Emp();
                // employee.Empno = 2979;
                employee.Ename = "Roja";
                ctx.Update(employee);
                ctx.SaveChanges();
                Console.WriteLine("Updated");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void AddNewEmployee()
        {
            var ctx = new ThanmayContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 2300;
                employee.Ename = "Shailaja";
                employee.Sal = 1000;
                employee.Deptno = 30;
                employee.Job = "Trainer";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void RemoveNewEmployee()
        {
            var ctx = new ThanmayContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 2300;
                employee.Ename = "Shailaja";
                employee.Sal = 1000;
                employee.Deptno = 30;
                employee.Job = "Trainer";
                ctx.Remove(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee Deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        //private static void UpdateEmployeeWParam()        //This calls stored procedure with parameters.

        //{

        //    var ctx = new ThanmayContext();
        //    var EMP = ctx.Emps.FromSqlRaw("GetEmpsDetailsByEmpno @p0 ", 7698).ToList();
        //    foreach (var e in EMP)
        //    {
        //        Console.WriteLine(e.Ename);
        //        Console.WriteLine(e.Empno);
        //        Console.WriteLine(e.Job);

        //    }

        //}
        //private static void UpdateEmployeeWOParam()             //This calls stored procedure without parameters.
        //{
        //    var ctx = new ThanmayContext();
        //    var employees = ctx.Emps.FromSqlRaw($"GetEmpDetails").ToList();



        //    foreach (var e in employees)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}
        //private static void UpdateEmployeeWOParam()

        //{

        //    var ctx = new ThanmayContext();
        //    var EMP = ctx.Emps.ExecuteSqlCommand("Updatenames @p0, @p1",Empno,Ename).ToList();
        //    foreach (var e in EMP)
        //    {
        //        Console.WriteLine(e.Ename);

        //    }

        //}


        /*        private static void GetEmpDetailByID()
                {
                    var ctx = new TrainingContext();
                    var employee = ctx.Emps.Where(e=>e.Empno==7499).SingleOrDefault();
                    Console.WriteLine(employee.Ename + "  " + employee.Sal+"  "+ employee.Job);

                }*/
        /*        private static void GetAllEmpDetails()
                {
                    var ctx = new TrainingContext();
                    var emp = ctx.Emps;

                    foreach(var employee in emp)
                    {
                        Console.WriteLine(employee.Ename + " " + employee.Sal);
                    }

                }*/

        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new ThanmayContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 50,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Megan"
                        },



                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value =7566
                        },

                        new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 50,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Trainer"


                        }

                      };



            try
            {
                var result = ctx.Database.ExecuteSqlRaw("InsertEmployee  @ename, @empno, @job",
                                                            param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {



                throw;
            }




            Console.WriteLine("update successful");



        }
    }
}

