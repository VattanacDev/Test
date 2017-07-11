console.log(__filename);
console.log(__dirname);
function printstuff(){
//  console.log("Time setout was call");
console.log("setInterval was call");
}
//setTimeout(printstuff,5000);
setInterval(printstuff,2000);
