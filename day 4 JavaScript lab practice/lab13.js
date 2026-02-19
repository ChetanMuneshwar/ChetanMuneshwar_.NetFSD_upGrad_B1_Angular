//sum of an array
// avarage of an array
// count the even element
// count the odd element

let numbers = [12, 7, 9, 20, 33, 18, 5];

let sum = 0;
let avarage = 0;
let evenCount = 0;
let oddCount = 0;

for(let i = 0 ; i<numbers.length ; i++) {
    sum+= numbers[i];
}

console.log("sum of an arrays element : "+sum)

avarage = sum/numbers.length;
console.log("avg of an arrays element : "+avarage)

for(let i = 0 ; i<numbers.length ; i++) {
    if(numbers[i]%2==0)
        evenCount++;
    else 
        oddCount++;
}
console.log("Even Element count of an arrays element : "+evenCount)
console.log("odd Element count of an arrays element : "+oddCount)