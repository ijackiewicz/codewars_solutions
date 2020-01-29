function persistence(num) {
   if (num<10) return 0;
   var steps = 0;
   var numS = num.toString();
   do {
     var sum = 1;
     for (var i=0;i<numS.toString().length;i++) {
       sum *= parseInt(numS.charAt(i));
     }     
       steps++;
       numS = sum.toString();
   } while (sum>9)
   return steps;
}
