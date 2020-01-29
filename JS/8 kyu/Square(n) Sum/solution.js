function squareSum(numbers){
  if (!(Array.isArray(numbers) && numbers.length)) return 0;
  var sum = numbers.map(x => Math.pow(x,2)).reduce(function(a, b) {
  return a + b;
});;
  return sum;
}
