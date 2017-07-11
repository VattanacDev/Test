function relay(){
  console.log("this is relay function");
}
function longjump() {
  console.log("this is longjump function");
}
module.exports.relay = relay;
module.exports.longjump=longjump;
