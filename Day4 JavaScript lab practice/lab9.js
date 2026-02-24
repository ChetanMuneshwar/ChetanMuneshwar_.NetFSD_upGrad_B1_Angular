// find largest and smallest element from an array

let numbers = [10,20,30,40,50];

let largest = numbers[0];
let smallest = numbers[0];

for(let i = 0 ; i<numbers.length ; i++)
{
    if(numbers[i]>largest)
    {
        largest = numbers[i];
    }
}
console.log("Largest element from ans array : "+largest);

for(let i = 0 ; i<numbers.length ; i++)
{
    if(numbers[i]<smallest)
    {
        smallest = numbers[i];
    }
}
console.log("smallest element from ans array : "+smallest);