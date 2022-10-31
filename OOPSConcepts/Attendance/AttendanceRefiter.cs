using System;
namespace Attendance;
public class Attendance
    {
        private double _workingDays;//total working days in month
        private double _leaves;//number of leaves taken
        private double _permissions;//number of permissions taken
        public Attendance()
        {

        }
        public Attendance(double workingDays,double leaves,double permissions)
        {
            _workingDays=workingDays;
            _leaves=leaves;
            _permissions=permissions;
        }
        public Attendance Add(Attendance month1,Attendance month2,Attendance month3)
        {
            Attendance attendance = new Attendance();
            _workingDays=month1._workingDays+month2._workingDays+month3._workingDays;
            _permissions=month1._permissions+month2._permissions+month3._permissions;
            _leaves=month1._leaves+month2._leaves+month3._leaves;
            return attendance;
        }
        public double CalculateSalary()
        {
            double salary = (_workingDays-_leaves-_permissions)*500;
            return salary;
        }
        
    }

