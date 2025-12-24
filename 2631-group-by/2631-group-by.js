/**
 * @param {Function} fn
 * @return {Object}
 */
Array.prototype.groupBy = function(fn) {
    let groupArr={};
    let keyFn; 
    for(let i=0;i<this.length;i++) {
        keyFn=fn(this[i]);
        if(keyFn in groupArr) {
            groupArr[keyFn].push(this[i]);
        }
        else {
            groupArr[keyFn]=[this[i]];
        }
    }
    return groupArr;
};

/**
 * [1,2,3].groupBy(String) // {"1":[1],"2":[2],"3":[3]}
 */