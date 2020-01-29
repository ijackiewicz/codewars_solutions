var number = function(busStops){
  var sum = 0;
  for (var i = 0; i < busStops.length; i++) {
    sum += busStops[i][0] - busStops[i][1];
  }
  return sum;
}
