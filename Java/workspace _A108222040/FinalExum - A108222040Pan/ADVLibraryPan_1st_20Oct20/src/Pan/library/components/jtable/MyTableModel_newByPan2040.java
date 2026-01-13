package Pan.library.components.jtable;

import java.awt.Color;

import javax.swing.table.AbstractTableModel;

public class MyTableModel_newByPan2040 extends AbstractTableModel {
	private boolean DEBUG = false;
    private String[] columnNames = {"First Name",
                                    "Favorite Color",
                                    "Sport",
                                    "# of Years",
                                    "Vegetarian"};
    private Object[][] data = {
        {"Mary", new Color(153, 0, 153),
         "Snowboarding", new Integer(5), new Boolean(false)},
        {"Alison", new Color(51, 51, 153),
         "Rowing", new Integer(3), new Boolean(true)},
        {"Kathy", new Color(51, 102, 51),
         "Knitting", new Integer(2), new Boolean(false)},
        {"Sharon", Color.red,
         "Speed reading", new Integer(20), new Boolean(true)},
        {"Philip", Color.pink,
         "Pool", new Integer(10), new Boolean(false)}
    };
	

    /**
     * added by Pan
     */
    public MyTableModel_newByPan2040()
    {
    	
    }
    
    /**
     * added by Pan
     */
    public MyTableModel_newByPan2040(String[] names, Object[][] _data)
    {
    	columnNames = names;
    	data = _data;
    }
    
    public int getColumnCount() {
        return columnNames.length;
    }

    public int getRowCount() {
        return data.length;
    }

    public String getColumnName(int col) {
        return columnNames[col];
    }

    public Object getValueAt(int row, int col) {
        return data[row][col];
    }

    /*
     * JTable uses this method to determine the default renderer/
     * editor for each cell.  If we didn't implement this method,
     * then the last column would contain text ("true"/"false"),
     * rather than a check box.
     */
    public Class getColumnClass(int c) {
        return getValueAt(0, c).getClass();
    }

    public boolean isCellEditable(int row, int col) {
        //Note that the data/cell address is constant,
        //no matter where the cell appears onscreen.
        if (col < 1) {
            return false;
        } else {
            return true;
        }
    }

    public void setValueAt(Object value, int row, int col) {
        if (DEBUG) {
            System.out.println("Setting value at " + row + "," + col
                               + " to " + value
                               + " (an instance of "
                               + value.getClass() + ")");
        }

        data[row][col] = value;
        fireTableCellUpdated(row, col);

        if (DEBUG) {
            System.out.println("New value of data:");
            printDebugData();
        }
    }

    private void printDebugData() {
        int numRows = getRowCount();
        int numCols = getColumnCount();

        for (int i=0; i < numRows; i++) {
            System.out.print("    row " + i + ":");
            for (int j=0; j < numCols; j++) {
                System.out.print("  " + data[i][j]);
            }
            System.out.println();
        }
        System.out.println("--------------------------");
    }
}