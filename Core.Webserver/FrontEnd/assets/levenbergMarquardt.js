class Matrix {
    constructor(numRows, numCols) {
        this.data = []
        this.numRows = numRows;
        this.numCols = numCols;

        const numEls = this.numRows * this.numCols;
        for (let i = 0; i < numEls; i++) {
            this.data.push(0);
        }
    }

    getIndex(row, col) {
        return row * this.numCols + col;
    }

    get(row, col) {
        return this.data[this.getIndex(row, col)];
    }

    set(row, col, val) {
        this.data[this.getIndex(row, col)] = val;
    }

    print() {
        let str = ''

        for (let row = 0; row < this.numRows; row++) {
            str += '[';
            for (let col = 0; col < this.numCols; col++) {
                str += this.get(row, col).toFixed(2);
                str += col + 1 < this.numCols ? ', ' : '';
            }
            str += ']\n';
        }

        console.log(str);
    }

    clone() {
        const clone = new Matrix(this.numRows, this.numCols);

        for (let row = 0; row < this.numRows; row++) {
            for (let col = 0; col < this.numCols; col++) {
                clone.set(row, col, this.get(row, col));
            }
        }

        return clone;
    }

    subtract(other) {
        const res = this.clone();
        res.data = this.data.map((val, i) => val - other[i]);

        return res;
    }
}

function calculateResidual(data, model) {
    const mat = new Matrix(data.input.length, 1);
    data.input.forEach((inp, i) => {
        mat.set(i, 0, model.param[0] * inp[0] ** model.param[1]);
    });

    mat.subtract(data.output);
}

function levenbergMarquardt(data, model, options) {
    const result = {
        iterationValues: model.param.clone(),
    };
    const residual = calculateResidual(data, model);
}

levenbergMarquardt();
