// prime number from 1 to 20

let start = 1 ;
let end = 20 ;

while(start<=end){
    let den = 2;

    while(den<=start)
    {
        if(start%den==0)
        {
            break;
        }
        den++;
    }
    if(start==den)
        console.log("prime Number : "+start);
    start++;
}