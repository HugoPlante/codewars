function findNextSquare(sq) {
    let root = Math.sqrt(sq);
    if (Number.isInteger(root)) return Math.pow(root + 1, 2);
    return -1;
}