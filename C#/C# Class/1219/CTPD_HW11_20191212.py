import matplotlib.pyplot as plt

def main():
    x_coords = [0,1,2,3,4]
    y_coords = [0,3,1,5,2]
    
    plt.plot(x_coords,y_coords)
    
    plt.show()
    
main()    

def main ():
    x_coords = [0,1,2,3,4]
    y_coords = [0,3,1,5,2]
    
    plt.plot(x_coords,y_coords)
    
    plt.title('Sample Data')
    
    plt.xlabel('This is the X axis')
    plt.xlabel('This is the Y axis')
    
    plt.grid(True)
    
    plt.show()
    
main()    

def main():
    x_coords = [0, 1, 2, 3, 4]
    y_coords = [0, 3, 1, 5, 2]
    
    plt.plot(x_coords, y_coords)

    plt.title('Sample Data')

    plt.xlabel('This is the X axis')
    plt.ylabel('This is the Y axis')

    plt.xlim(xmin=-1, xmax=10)
    plt.ylim(ymin=-1, ymax=6)

    plt.grid(True)

    plt.show()

main()

def main():

    x_coords = [0, 1, 2, 3, 4]
    y_coords = [0, 3, 1, 5, 2]

    plt.plot(x_coords, y_coords)

    plt.title('Sales by Year')

    plt.xlabel('Year')
    plt.ylabel('Sales')

    plt.xticks([0, 1, 2, 3, 4],
               ['2016', '2017', '2018', '2019', '2020'])
    plt.yticks([0, 1, 2, 3, 4, 5],
               ['$0m', '$1m', '$2m', '$3m', '$4m', '$5m'])

    plt.grid(True)

    plt.show()

main()

def main():

    x_coords = [0, 1, 2, 3, 4]
    y_coords = [0, 3, 1, 5, 2]

    plt.plot(x_coords, y_coords, marker='o')

    plt.title('Sales by Year')

    plt.xlabel('Year')
    plt.ylabel('Sales')

    plt.xticks([0, 1, 2, 3, 4],
               ['2016', '2017', '2018', '2019', '2020'])
    plt.yticks([0, 1, 2, 3, 4, 5],
               ['$0m', '$1m', '$2m', '$3m', '$4m', '$5m'])

    plt.grid(True)

    plt.show()

main()

def main():

    left_edges = [0, 10, 20, 30, 40]

    heights = [100, 200, 300, 400, 500]

    plt.bar(left_edges, heights)

    plt.show()

main()

def main():

    left_edges = [0, 10, 20, 30, 40]

    heights = [100, 200, 300, 400, 500]

    bar_width = 5

    plt.bar(left_edges, heights, bar_width)

    plt.show()

main()

def main():

    left_edges = [0, 10, 20, 30, 40]

    heights = [100, 200, 300, 400, 500]

    bar_width = 10

    plt.bar(left_edges, heights, bar_width, color=('r', 'g', 'b', 'w', 'k'))

    plt.title('Sales by Year')

    plt.xlabel('Year')
    plt.ylabel('Sales')

    plt.xticks([5, 15, 25, 35, 45],
               ['2016', '2017', '2018', '2019', '2020'])
    plt.yticks([0, 100, 200, 300, 400, 500],
               ['$0m', '$1m', '$2m', '$3m', '$4m', '$5m'])

    plt.show()

main()

def main():

    values = [20, 60, 80, 40]

    plt.pie(values)
 
    plt.show()

main()

def main():

    sales = [100, 400, 300, 600]

    slice_labels = ['1st Qtr', '2nd Qtr', '3rd Qtr', '4th Qtr']

    plt.pie(sales, labels=slice_labels)

    plt.title('Sales by Quarter')

    plt.show()

main()