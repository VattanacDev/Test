var events =require('events');
var eventEmitter=new events.EventEmitter();
var ringbell=function(){
  console.log("ring ring");
  eventEmitter.emit('bellring','welcome');
 }
eventEmitter.on('doorOpen',ringbell);
eventEmitter.on('bellring',function(message){
  console.log(message);
})
eventEmitter.emit('doorOpen');
