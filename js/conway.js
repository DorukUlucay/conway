conway = {

    _size: 16,

    world: null,

    init: function() {
        conway.world = conway.getEmptyWorld(conway._size);

        conway.world[8][8] = 1;
        conway.world[9][9] = 1;
        conway.world[10][9] = 1;
        conway.world[10][8] = 1;
        conway.world[10][7] = 1;

    },

    iterate: function() {
        var newWorld = conway.getEmptyWorld(conway._size);

        for (x = 0; x < conway._size; x++) {
            for (y = 0; y < conway._size; y++) {
                var neighborCount = conway.getAliveNeighborCount(x, y);

                if (conway.world[x][y] == 0) {
                    if (neighborCount == 3) {
                        newWorld[x][y] = 1;
                    } else {
                        newWorld[x][y] = conway.world[x][y];
                    }
                } else {
                    if (neighborCount < 2) {
                        newWorld[x][y] = 0;
                    } else if (neighborCount > 3) {
                        newWorld[x][y] = 0;
                    } else {
                        newWorld[x][y] = conway.world[x][y];
                    }
                }
            }
        }
        conway.world = newWorld;
        return conway.world;
    },

    isOutOfBounds: function(x, y) {
        if (x >= conway._size || x < 0 || y >= conway._size || y < 0) {
            return true;
        }
        return false;
    },

    getAliveNeighborCount: function(x, y) {
        var count = 0;
        for (i = -1; i < 2; i++) {
            for (j = -1; j < 2; j++) {
                if (!conway.isOutOfBounds(x + i, y + j)) {
                    if (i == 0 && j == 0) {

                    } else {
                        if (conway.world[x + i][y + j] == 1) {
                            count++;
                        }
                    }
                }
            }
        }
        return count;
    },

    getEmptyWorld: function(size) {
        var _w = [];
        for (y = 0; y < size; y++) {
            _w[y] = [];

            for (x = 0; x < size; x++) {
                _w[y][x] = 0;
            }
        }
        return _w;
    }
}