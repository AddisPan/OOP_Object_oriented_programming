package Pan.library.guidesign;
// Fig. 17.6: BankUI.java
// A reusable GUI for the examples in this chapter.


import java.awt.*;
import javax.swing.*;

import com.deitel.jhtp5.ch17.AccountRecord;
import Pan2040.fs.bank.seqntial.swing.gui.BankUI_4Btn;

public class GenericGUIdesigninglnSwing extends JPanel {
	/*
   // label text for GUI
   protected final static String names[] = { "Account number",
      "First name", "Last name", "Balance", "Transaction Amount" };
      */
	
   private static final long serialVersionUID = 1L;
   
   //label text for GUI
   protected String[] lblNames;
   // GUI components; protected for future subclass access
   protected JLabel labels[];
   protected JTextField fields[];
   /**
   *protected JButton doTask1, doTask2,doTask3,doTask4;
   */
   
   protected int taskNo4btns;
   protected JButton[] doTaskBtn;
   
   protected JPanel innerPanelCenter, innerPanelSouth;

   protected int size; // number of text fields in GUI

   /**
   * constants representing text fields in GUI
   *public static final int ACCOUNT = 0, FIRSTNAME = 1, LASTNAME = 2, 
    *  BALANCE = 3, TRANSACTION = 4;
	*/

   // Set up GUI. Constructor argument size determines the number of
   // rows of GUI components.
   public GenericGUIdesigninglnSwing(int _taskNo4btns,String[] _lblName)
   {
      size = _lblName.length;
      taskNo4btns =_taskNo4btns;
      labels = new JLabel[ size ];
      fields = new JTextField[ size ];
      doTaskBtn = new JButton[taskNo4btns];
      
      lblNames = _lblName;

      // create labels
      for ( int count = 0; count < labels.length; count++ )
         labels[ count ] = new JLabel(lblNames[ count ] );
            
      // create text fields
      for ( int count = 0; count < fields.length; count++ )
         fields[ count ] = new JTextField();

      // create panel to lay out labels and fields
      innerPanelCenter = new JPanel();
      innerPanelCenter.setLayout( new GridLayout( size, 2 ) );

      // attach labels and fields to innerPanelCenter
      for ( int count = 0; count < size; count++ ) {
         innerPanelCenter.add( labels[ count ] );
         innerPanelCenter.add( fields[ count ] );
      }
      
      /*
      // create generic buttons; no labels or event handlers
      doTask1 = new JButton();
      doTask2 = new JButton(); 
      doTask3 = new JButton();
      doTask4 = new JButton();
	  */

      // create panel to lay out buttons and attach buttons
//      innerPanelSouth = new JPanel();      
//      innerPanelSouth.add( doTask1 );
//      innerPanelSouth.add( doTask2 );
//      innerPanelSouth.add( doTask3 );
//      innerPanelSouth.add( doTask4 );
      
      innerPanelSouth = new JPanel();
      
      for(int task = 0 ;task < taskNo4btns; task++)
      {
    	  doTaskBtn[task] = new JButton();
    	  innerPanelSouth.add(doTaskBtn[task]);
      }

      // set layout of this container and attach panels to it
      setLayout( new BorderLayout() );
      add( innerPanelCenter, BorderLayout.CENTER );
      add( innerPanelSouth, BorderLayout.SOUTH );

      validate(); // validate layout 

   } // end constructor

   /*
   // return reference to generic task button doTask1
   public JButton getDoTask1Button() 
   { 
      return doTask1; 
   }

   // return reference to generic task button doTask2
   public JButton getDoTask2Button() 
   { 
      return doTask2; 
   }
   
   public JButton getDoTask3Button() 
   { 
      return doTask3; 
   }

   // return reference to generic task button doTask2
   public JButton getDoTask4Button() 
   { 
      return doTask4; 
   }
   */
   
   public JButton customJButton(JButton doTaskBtn,ImageIcon icon,String btnOptionType,
		   Color foregroundColor,Color backgroundColor,Font font)
   {
	   doTaskBtn.setHorizontalAlignment(SwingConstants.RIGHT);
	   doTaskBtn.setForeground(foregroundColor);
	   doTaskBtn.setFont(font);
	   doTaskBtn.setBackground(backgroundColor);
//     doTaskBtn.setBounds(433,657,124,30);//it seems this line is no use here
	   
	   doTaskBtn.setIcon(icon);
	   doTaskBtn.setToolTipText(btnOptionType);
	   doTaskBtn.setText(btnOptionType);
	   
	   System.out.println("i="+icon.toString());
	   return doTaskBtn;
   }

   public JButton getDoTaskButton(int taskIndex) 
   { 
      for (int task = 0; task < taskNo4btns;task++)
      {
    	  if(task==taskIndex)
    	  return doTaskBtn[task];
      }
      return null;
   }
   
   // return reference to fields array of JTextFields
   public JTextField[] getFields() 
   { 
      return fields; 
   }

   // clear content of text fields
   public void clearFields()
   {
      for ( int count = 0; count < size; count++ )
         fields[ count ].setText( "" );
   }
   
   public void disableFields()
   {
	   for(int count = 0;count < size;count++)
		   fields[count].setText("");
   }

   // set text field values; throw IllegalArgumentException if
   // incorrect number of Strings in argument
   public void setFieldValues( String strings[] )
      throws IllegalArgumentException
   {
      if ( strings.length != size )
         throw new IllegalArgumentException( "There must be " + size + " Strings in the array" );

      for ( int count = 0; count < size; count++ )
         fields[ count ].setText( strings[ count ] );
   }

   // get array of Strings with current text field contents
   public String[] getFieldValues()
   { 
      String values[] = new String[ size ];

      for ( int count = 0; count < size; count++ ) 
         values[ count ] = fields[ count ].getText();

      return values;
   }

} // end class BankUI


/**************************************************************************
 * (C) Copyright 1992-2003 by Deitel & Associates, Inc. and               *
 * Prentice Hall. All Rights Reserved.                                    *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
