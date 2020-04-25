```js
class Matrix {
    constructor(mat) {
        this.data = mat;
        this.numRows = mat.length;
        this.numCols = mat[0].length;
    }

    get(row, col) {
        return this.data[row][col];
    }

    frobeniusNorm() {
        let sumSquared = this.data
            .reduce((acc1, cur1) => acc1 + cur1
                .reduce((acc2, cur2) => acc2 + cur2 ** 2, 0), 0);
        return Math.sqrt(sumSquared); 
    }
}

// const mat = new Matrix([[1, 2], [3, 4]])

// console.log(mat.frobeniusNorm());


class LevenbergMarquardt {
    constructor() {
        this.maxIterations = 100;
        this.funcionTolerance = 1e-12;
        this.residualTolerance = 1e-12;

        this.initialCost = undefined;
        this.residuals = new Matrix([[], []])

        // Dampening. Larger values means it's more like gradient descent
        this.dampening = 1;
    }

    optimize(func, params) {
        this.func = func;

        this.initialCost = this.cost(params);
        let previousCost = this.initialCost;
    }

    cost(param) {
        this.func(param, this.residuals);

        const error = residuals.frobeniusNorm();

        return (error ** 2) / residuals.numRows;
    }
}

```