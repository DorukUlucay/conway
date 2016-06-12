import conway, time


size = 20
conway = conway.conway(size)


def printGrid(grid):
    for i in range(size):
        print str(grid[i]).replace('[','').replace(']','').replace(',',' ').replace('0', ' ')


while(True):
    time.sleep(0.5)
    printGrid(conway.takeAStep())
    print("\n")
