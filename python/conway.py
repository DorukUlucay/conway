class conway:

    size = 20

    grid = [[0 for col in range(size)] for row in range(size)]
    nextgen = [[0 for col in range(size)] for row in range(size)]

    def __init__(self, size):
        self.size = size

        # blinker seed
        self.grid[2][3] = 1
        self.grid[2][4] = 1
        self.grid[2][5] = 1

        # glider seed
        self.grid[8][8] = 1
        self.grid[9][9] = 1
        self.grid[10][9] = 1
        self.grid[10][8] = 1
        self.grid[10][7] = 1



    def getGrid(self):
        return self.grid


    def iterate(self):

        for col in range(self.size):
            for row in range(self.size):
                neighbors = self.getNeighbors(col, row)

                if self.grid[col][row] == 1:
                    if  neighbors < 2:
                        self.nextgen[col][row] = 0
                    elif neighbors > 3:
                        self.nextgen[col][row] = 0
                    else:
                        self.nextgen[col][row] = self.grid[col][row]
                elif self.grid[col][row] == 0:
                    if neighbors == 3:
                        self.nextgen[col][row] = 1
                    else:
                        self.nextgen[col][row] = self.grid[col][row]


    def getNeighbors(self, col, row):
        count = 0
        for i in range(col-1, col+2):
            for j in range(row-1, row+2):
                if i == col and j == row:
                    pass
                else:
                    if not self.outOfBounds(i,j):
                        if self.grid[i][j] == 1:
                            count = count + 1
        return count


    def outOfBounds(self, x, y):
        if x==-1 or x == self.size or y == -1 or y == self.size:
            return True
        return False

    def Update(self):
        temp = self.nextgen
        self.nextgen = self.grid
        self.grid = temp

    def takeAStep(self):
        self.iterate()
        self.Update()
        return self.getGrid()
