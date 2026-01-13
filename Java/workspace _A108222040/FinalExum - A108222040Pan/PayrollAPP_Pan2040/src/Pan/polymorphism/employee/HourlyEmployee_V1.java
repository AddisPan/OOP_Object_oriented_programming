package Pan.polymorphism.employee;
// Fig. 10.6: HourlyEmployee.java
// HourlyEmployee class extends Employee.

public class HourlyEmployee_V1 extends Employee {
   private double hourlywage; // wage per hour
   private double hours; // hours worked for week
   private double extraHourRate;
   private double maxWorkedHours = 80;
   private double maxRate = 2.0;
   private double minRate = 1.0;
   private double normalWH = 40;

   // constructor
   public HourlyEmployee_V1(String _firstName, String _lastName,String _socialSecurityNumber, boolean _isSimpleFormat, 
		   double _hourlywage, double _hours,double _extraHourRate) {
      super(_firstName, _lastName, _socialSecurityNumber,_isSimpleFormat);

      if (_hourlywage < 0.0) { // validate wage
         throw new IllegalArgumentException("Hourly wage must be >= 0.0");
      }

      if ((_hours < 0.0) || (_hours > maxWorkedHours)) { // validate hours
         throw new IllegalArgumentException(
            "Hours worked must be >= 0.0 and <= maxWorkedHours");
      }
      
      if ((_extraHourRate < minRate) || (_extraHourRate > maxRate)) { // validate hours
          throw new IllegalArgumentException("Extra-Hour Rate must be and >=minRate and <=maxRate");
       }

      this.hourlywage = _hourlywage;
      this.hours = _hours;
      this.extraHourRate = _extraHourRate;
   } 

   // set wage
   public void setWage(double wage) {
      if (wage < 0.0) { // validate wage
         throw new IllegalArgumentException("Hourly wage must be >= 0.0");
      }

      this.hourlywage = wage;
   } 

   // return wage
   public double getWage() {return hourlywage;}

   // set hours worked
   public void setHours(double hours) {
      if ((hours < 0.0) || (hours > 168.0)) { // validate hours
         throw new IllegalArgumentException(
            "Hours worked must be >= 0.0 and <= 168.0");
      }

      this.hours = hours;
   } 

   // return hours worked
   public double getHours() {return hours;}
   
// set base salary
   public void setextraHourRate(double _extraHourRate) {
      if (extraHourRate < 1.0) { // validate baseSalary                  
         throw new IllegalArgumentException("Extra-Hour Rate must be >= 0.0");
      }
            
      this.extraHourRate = _extraHourRate;                
   } 

   // return base salary
   public double getextraHourRate() {return extraHourRate;}

   // calculate earnings; override abstract method earnings in Employee
   @Override                                                           
   public double earnings() {                                          
      if (getHours() <= normalWH) { // no overtime                           
         return getWage() * getHours();                                
      }                                                                
      else {                                                           
         return normalWH * getWage() + (getHours() - 40) * getWage() * getextraHourRate();  
      }                                                                
   }                                                                   

   // return String representation of HourlyEmployee object              
   @Override                                                           
   public String toString() {      
	   return String.format(
	   isSimpleFormat ? ("\n%10s\t%50s\t%15.2f\t%15.2f\t%15.2f\t%15.2f")
                      : ("\n%10s\t%50s\t%15.2f\t%15.2f\t%15.2f\t%15.2f"),
       "H-Employee",super.toString(), getWage(),getHours(),getextraHourRate(),earnings());                            
   }      
   
   @Override
   public String toString2() {                                          
	      return String.format("hourly employee: %s%n%s: $%,.2f; %s: $%,.2f %s: %,.2f", super.toString2(),"hourly wage",
	    		  getWage(),"hours worked",getHours(),"rate",getextraHourRate());                              
	   }        
   
   @Override
   public String toString3() {                                          
	      return String.format("\r\n%10s, %s, %,15.2f, %15.2f, %15.2f , %15.2f","H-Employee",super.toString3(),
	    		  getWage(),getHours(),getextraHourRate(),earnings());                              
	   }                                                                 
} 