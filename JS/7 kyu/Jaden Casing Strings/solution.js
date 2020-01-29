String.prototype.toJadenCase = function () {
  return this.replace(/(^\w{1})|(\s{1}\w{1})/g, match => match.toUpperCase());
};
