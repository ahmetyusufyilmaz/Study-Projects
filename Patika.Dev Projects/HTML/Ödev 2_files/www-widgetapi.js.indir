(function(){/*

 Copyright The Closure Library Authors.
 SPDX-License-Identifier: Apache-2.0
*/
'use strict';var n;function aa(a){var b=0;return function(){return b<a.length?{done:!1,value:a[b++]}:{done:!0}}}
var ba="function"==typeof Object.defineProperties?Object.defineProperty:function(a,b,c){if(a==Array.prototype||a==Object.prototype)return a;a[b]=c.value;return a};
function ca(a){a=["object"==typeof globalThis&&globalThis,a,"object"==typeof window&&window,"object"==typeof self&&self,"object"==typeof global&&global];for(var b=0;b<a.length;++b){var c=a[b];if(c&&c.Math==Math)return c}throw Error("Cannot find global object");}
var da=ca(this);function r(a,b){if(b)a:{var c=da;a=a.split(".");for(var d=0;d<a.length-1;d++){var e=a[d];if(!(e in c))break a;c=c[e]}a=a[a.length-1];d=c[a];b=b(d);b!=d&&null!=b&&ba(c,a,{configurable:!0,writable:!0,value:b})}}
r("Symbol",function(a){function b(f){if(this instanceof b)throw new TypeError("Symbol is not a constructor");return new c(d+(f||"")+"_"+e++,f)}
function c(f,g){this.h=f;ba(this,"description",{configurable:!0,writable:!0,value:g})}
if(a)return a;c.prototype.toString=function(){return this.h};
var d="jscomp_symbol_"+(1E9*Math.random()>>>0)+"_",e=0;return b});
r("Symbol.iterator",function(a){if(a)return a;a=Symbol("Symbol.iterator");for(var b="Array Int8Array Uint8Array Uint8ClampedArray Int16Array Uint16Array Int32Array Uint32Array Float32Array Float64Array".split(" "),c=0;c<b.length;c++){var d=da[b[c]];"function"===typeof d&&"function"!=typeof d.prototype[a]&&ba(d.prototype,a,{configurable:!0,writable:!0,value:function(){return fa(aa(this))}})}return a});
function fa(a){a={next:a};a[Symbol.iterator]=function(){return this};
return a}
function t(a){var b="undefined"!=typeof Symbol&&Symbol.iterator&&a[Symbol.iterator];return b?b.call(a):{next:aa(a)}}
function ha(a){if(!(a instanceof Array)){a=t(a);for(var b,c=[];!(b=a.next()).done;)c.push(b.value);a=c}return a}
var ia="function"==typeof Object.create?Object.create:function(a){function b(){}
b.prototype=a;return new b},ja;
if("function"==typeof Object.setPrototypeOf)ja=Object.setPrototypeOf;else{var ka;a:{var ma={a:!0},na={};try{na.__proto__=ma;ka=na.a;break a}catch(a){}ka=!1}ja=ka?function(a,b){a.__proto__=b;if(a.__proto__!==b)throw new TypeError(a+" is not extensible");return a}:null}var oa=ja;
function v(a,b){a.prototype=ia(b.prototype);a.prototype.constructor=a;if(oa)oa(a,b);else for(var c in b)if("prototype"!=c)if(Object.defineProperties){var d=Object.getOwnPropertyDescriptor(b,c);d&&Object.defineProperty(a,c,d)}else a[c]=b[c];a.N=b.prototype}
function pa(){this.u=!1;this.l=null;this.i=void 0;this.h=1;this.m=this.v=0;this.I=this.j=null}
function qa(a){if(a.u)throw new TypeError("Generator is already running");a.u=!0}
pa.prototype.B=function(a){this.i=a};
function ra(a,b){a.j={Na:b,Ra:!0};a.h=a.v||a.m}
pa.prototype.return=function(a){this.j={return:a};this.h=this.m};
function w(a,b,c){a.h=c;return{value:b}}
pa.prototype.o=function(a){this.h=a};
function sa(a,b,c){a.v=b;void 0!=c&&(a.m=c)}
function ta(a,b){a.h=b;a.v=0}
function ua(a){a.v=0;var b=a.j.Na;a.j=null;return b}
function va(a){a.I=[a.j];a.v=0;a.m=0}
function xa(a){var b=a.I.splice(0)[0];(b=a.j=a.j||b)?b.Ra?a.h=a.v||a.m:void 0!=b.o&&a.m<b.o?(a.h=b.o,a.j=null):a.h=a.m:a.h=0}
function ya(a){this.h=new pa;this.i=a}
function za(a,b){qa(a.h);var c=a.h.l;if(c)return Aa(a,"return"in c?c["return"]:function(d){return{value:d,done:!0}},b,a.h.return);
a.h.return(b);return Ba(a)}
function Aa(a,b,c,d){try{var e=b.call(a.h.l,c);if(!(e instanceof Object))throw new TypeError("Iterator result "+e+" is not an object");if(!e.done)return a.h.u=!1,e;var f=e.value}catch(g){return a.h.l=null,ra(a.h,g),Ba(a)}a.h.l=null;d.call(a.h,f);return Ba(a)}
function Ba(a){for(;a.h.h;)try{var b=a.i(a.h);if(b)return a.h.u=!1,{value:b.value,done:!1}}catch(c){a.h.i=void 0,ra(a.h,c)}a.h.u=!1;if(a.h.j){b=a.h.j;a.h.j=null;if(b.Ra)throw b.Na;return{value:b.return,done:!0}}return{value:void 0,done:!0}}
function Ca(a){this.next=function(b){qa(a.h);a.h.l?b=Aa(a,a.h.l.next,b,a.h.B):(a.h.B(b),b=Ba(a));return b};
this.throw=function(b){qa(a.h);a.h.l?b=Aa(a,a.h.l["throw"],b,a.h.B):(ra(a.h,b),b=Ba(a));return b};
this.return=function(b){return za(a,b)};
this[Symbol.iterator]=function(){return this}}
function Da(a){function b(d){return a.next(d)}
function c(d){return a.throw(d)}
return new Promise(function(d,e){function f(g){g.done?d(g.value):Promise.resolve(g.value).then(b,c).then(f,e)}
f(a.next())})}
function z(a){return Da(new Ca(new ya(a)))}
function Ea(){for(var a=Number(this),b=[],c=a;c<arguments.length;c++)b[c-a]=arguments[c];return b}
r("Reflect.setPrototypeOf",function(a){return a?a:oa?function(b,c){try{return oa(b,c),!0}catch(d){return!1}}:null});
r("Promise",function(a){function b(g){this.h=0;this.j=void 0;this.i=[];this.u=!1;var h=this.l();try{g(h.resolve,h.reject)}catch(k){h.reject(k)}}
function c(){this.h=null}
function d(g){return g instanceof b?g:new b(function(h){h(g)})}
if(a)return a;c.prototype.i=function(g){if(null==this.h){this.h=[];var h=this;this.j(function(){h.m()})}this.h.push(g)};
var e=da.setTimeout;c.prototype.j=function(g){e(g,0)};
c.prototype.m=function(){for(;this.h&&this.h.length;){var g=this.h;this.h=[];for(var h=0;h<g.length;++h){var k=g[h];g[h]=null;try{k()}catch(l){this.l(l)}}}this.h=null};
c.prototype.l=function(g){this.j(function(){throw g;})};
b.prototype.l=function(){function g(l){return function(m){k||(k=!0,l.call(h,m))}}
var h=this,k=!1;return{resolve:g(this.va),reject:g(this.m)}};
b.prototype.va=function(g){if(g===this)this.m(new TypeError("A Promise cannot resolve to itself"));else if(g instanceof b)this.eb(g);else{a:switch(typeof g){case "object":var h=null!=g;break a;case "function":h=!0;break a;default:h=!1}h?this.ka(g):this.v(g)}};
b.prototype.ka=function(g){var h=void 0;try{h=g.then}catch(k){this.m(k);return}"function"==typeof h?this.fb(h,g):this.v(g)};
b.prototype.m=function(g){this.B(2,g)};
b.prototype.v=function(g){this.B(1,g)};
b.prototype.B=function(g,h){if(0!=this.h)throw Error("Cannot settle("+g+", "+h+"): Promise already settled in state"+this.h);this.h=g;this.j=h;2===this.h&&this.cb();this.I()};
b.prototype.cb=function(){var g=this;e(function(){if(g.O()){var h=da.console;"undefined"!==typeof h&&h.error(g.j)}},1)};
b.prototype.O=function(){if(this.u)return!1;var g=da.CustomEvent,h=da.Event,k=da.dispatchEvent;if("undefined"===typeof k)return!0;"function"===typeof g?g=new g("unhandledrejection",{cancelable:!0}):"function"===typeof h?g=new h("unhandledrejection",{cancelable:!0}):(g=da.document.createEvent("CustomEvent"),g.initCustomEvent("unhandledrejection",!1,!0,g));g.promise=this;g.reason=this.j;return k(g)};
b.prototype.I=function(){if(null!=this.i){for(var g=0;g<this.i.length;++g)f.i(this.i[g]);this.i=null}};
var f=new c;b.prototype.eb=function(g){var h=this.l();g.ma(h.resolve,h.reject)};
b.prototype.fb=function(g,h){var k=this.l();try{g.call(h,k.resolve,k.reject)}catch(l){k.reject(l)}};
b.prototype.then=function(g,h){function k(u,q){return"function"==typeof u?function(x){try{l(u(x))}catch(y){m(y)}}:q}
var l,m,p=new b(function(u,q){l=u;m=q});
this.ma(k(g,l),k(h,m));return p};
b.prototype.catch=function(g){return this.then(void 0,g)};
b.prototype.ma=function(g,h){function k(){switch(l.h){case 1:g(l.j);break;case 2:h(l.j);break;default:throw Error("Unexpected state: "+l.h);}}
var l=this;null==this.i?f.i(k):this.i.push(k);this.u=!0};
b.resolve=d;b.reject=function(g){return new b(function(h,k){k(g)})};
b.race=function(g){return new b(function(h,k){for(var l=t(g),m=l.next();!m.done;m=l.next())d(m.value).ma(h,k)})};
b.all=function(g){var h=t(g),k=h.next();return k.done?d([]):new b(function(l,m){function p(x){return function(y){u[x]=y;q--;0==q&&l(u)}}
var u=[],q=0;do u.push(void 0),q++,d(k.value).ma(p(u.length-1),m),k=h.next();while(!k.done)})};
return b});
function Fa(a,b){return Object.prototype.hasOwnProperty.call(a,b)}
r("WeakMap",function(a){function b(k){this.h=(h+=Math.random()+1).toString();if(k){k=t(k);for(var l;!(l=k.next()).done;)l=l.value,this.set(l[0],l[1])}}
function c(){}
function d(k){var l=typeof k;return"object"===l&&null!==k||"function"===l}
function e(k){if(!Fa(k,g)){var l=new c;ba(k,g,{value:l})}}
function f(k){var l=Object[k];l&&(Object[k]=function(m){if(m instanceof c)return m;Object.isExtensible(m)&&e(m);return l(m)})}
if(function(){if(!a||!Object.seal)return!1;try{var k=Object.seal({}),l=Object.seal({}),m=new a([[k,2],[l,3]]);if(2!=m.get(k)||3!=m.get(l))return!1;m.delete(k);m.set(l,4);return!m.has(k)&&4==m.get(l)}catch(p){return!1}}())return a;
var g="$jscomp_hidden_"+Math.random();f("freeze");f("preventExtensions");f("seal");var h=0;b.prototype.set=function(k,l){if(!d(k))throw Error("Invalid WeakMap key");e(k);if(!Fa(k,g))throw Error("WeakMap key fail: "+k);k[g][this.h]=l;return this};
b.prototype.get=function(k){return d(k)&&Fa(k,g)?k[g][this.h]:void 0};
b.prototype.has=function(k){return d(k)&&Fa(k,g)&&Fa(k[g],this.h)};
b.prototype.delete=function(k){return d(k)&&Fa(k,g)&&Fa(k[g],this.h)?delete k[g][this.h]:!1};
return b});
r("Map",function(a){function b(){var h={};return h.previous=h.next=h.head=h}
function c(h,k){var l=h.h;return fa(function(){if(l){for(;l.head!=h.h;)l=l.previous;for(;l.next!=l.head;)return l=l.next,{done:!1,value:k(l)};l=null}return{done:!0,value:void 0}})}
function d(h,k){var l=k&&typeof k;"object"==l||"function"==l?f.has(k)?l=f.get(k):(l=""+ ++g,f.set(k,l)):l="p_"+k;var m=h.data_[l];if(m&&Fa(h.data_,l))for(h=0;h<m.length;h++){var p=m[h];if(k!==k&&p.key!==p.key||k===p.key)return{id:l,list:m,index:h,entry:p}}return{id:l,list:m,index:-1,entry:void 0}}
function e(h){this.data_={};this.h=b();this.size=0;if(h){h=t(h);for(var k;!(k=h.next()).done;)k=k.value,this.set(k[0],k[1])}}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var h=Object.seal({x:4}),k=new a(t([[h,"s"]]));if("s"!=k.get(h)||1!=k.size||k.get({x:4})||k.set({x:4},"t")!=k||2!=k.size)return!1;var l=k.entries(),m=l.next();if(m.done||m.value[0]!=h||"s"!=m.value[1])return!1;m=l.next();return m.done||4!=m.value[0].x||"t"!=m.value[1]||!l.next().done?!1:!0}catch(p){return!1}}())return a;
var f=new WeakMap;e.prototype.set=function(h,k){h=0===h?0:h;var l=d(this,h);l.list||(l.list=this.data_[l.id]=[]);l.entry?l.entry.value=k:(l.entry={next:this.h,previous:this.h.previous,head:this.h,key:h,value:k},l.list.push(l.entry),this.h.previous.next=l.entry,this.h.previous=l.entry,this.size++);return this};
e.prototype.delete=function(h){h=d(this,h);return h.entry&&h.list?(h.list.splice(h.index,1),h.list.length||delete this.data_[h.id],h.entry.previous.next=h.entry.next,h.entry.next.previous=h.entry.previous,h.entry.head=null,this.size--,!0):!1};
e.prototype.clear=function(){this.data_={};this.h=this.h.previous=b();this.size=0};
e.prototype.has=function(h){return!!d(this,h).entry};
e.prototype.get=function(h){return(h=d(this,h).entry)&&h.value};
e.prototype.entries=function(){return c(this,function(h){return[h.key,h.value]})};
e.prototype.keys=function(){return c(this,function(h){return h.key})};
e.prototype.values=function(){return c(this,function(h){return h.value})};
e.prototype.forEach=function(h,k){for(var l=this.entries(),m;!(m=l.next()).done;)m=m.value,h.call(k,m[1],m[0],this)};
e.prototype[Symbol.iterator]=e.prototype.entries;var g=0;return e});
function Ga(a,b,c){if(null==a)throw new TypeError("The 'this' value for String.prototype."+c+" must not be null or undefined");if(b instanceof RegExp)throw new TypeError("First argument to String.prototype."+c+" must not be a regular expression");return a+""}
r("String.prototype.endsWith",function(a){return a?a:function(b,c){var d=Ga(this,b,"endsWith");b+="";void 0===c&&(c=d.length);c=Math.max(0,Math.min(c|0,d.length));for(var e=b.length;0<e&&0<c;)if(d[--c]!=b[--e])return!1;return 0>=e}});
r("Array.prototype.find",function(a){return a?a:function(b,c){a:{var d=this;d instanceof String&&(d=String(d));for(var e=d.length,f=0;f<e;f++){var g=d[f];if(b.call(c,g,f,d)){b=g;break a}}b=void 0}return b}});
r("String.prototype.startsWith",function(a){return a?a:function(b,c){var d=Ga(this,b,"startsWith");b+="";var e=d.length,f=b.length;c=Math.max(0,Math.min(c|0,d.length));for(var g=0;g<f&&c<e;)if(d[c++]!=b[g++])return!1;return g>=f}});
function Ha(a,b){a instanceof String&&(a+="");var c=0,d=!1,e={next:function(){if(!d&&c<a.length){var f=c++;return{value:b(f,a[f]),done:!1}}d=!0;return{done:!0,value:void 0}}};
e[Symbol.iterator]=function(){return e};
return e}
r("Array.prototype.entries",function(a){return a?a:function(){return Ha(this,function(b,c){return[b,c]})}});
r("Object.setPrototypeOf",function(a){return a||oa});
var Ia="function"==typeof Object.assign?Object.assign:function(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(d)for(var e in d)Fa(d,e)&&(a[e]=d[e])}return a};
r("Object.assign",function(a){return a||Ia});
r("Set",function(a){function b(c){this.h=new Map;if(c){c=t(c);for(var d;!(d=c.next()).done;)this.add(d.value)}this.size=this.h.size}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var c=Object.seal({x:4}),d=new a(t([c]));if(!d.has(c)||1!=d.size||d.add(c)!=d||1!=d.size||d.add({x:4})!=d||2!=d.size)return!1;var e=d.entries(),f=e.next();if(f.done||f.value[0]!=c||f.value[1]!=c)return!1;f=e.next();return f.done||f.value[0]==c||4!=f.value[0].x||f.value[1]!=f.value[0]?!1:e.next().done}catch(g){return!1}}())return a;
b.prototype.add=function(c){c=0===c?0:c;this.h.set(c,c);this.size=this.h.size;return this};
b.prototype.delete=function(c){c=this.h.delete(c);this.size=this.h.size;return c};
b.prototype.clear=function(){this.h.clear();this.size=0};
b.prototype.has=function(c){return this.h.has(c)};
b.prototype.entries=function(){return this.h.entries()};
b.prototype.values=function(){return this.h.values()};
b.prototype.keys=b.prototype.values;b.prototype[Symbol.iterator]=b.prototype.values;b.prototype.forEach=function(c,d){var e=this;this.h.forEach(function(f){return c.call(d,f,f,e)})};
return b});
r("Object.entries",function(a){return a?a:function(b){var c=[],d;for(d in b)Fa(b,d)&&c.push([d,b[d]]);return c}});
r("Array.prototype.keys",function(a){return a?a:function(){return Ha(this,function(b){return b})}});
r("Array.prototype.values",function(a){return a?a:function(){return Ha(this,function(b,c){return c})}});
r("Array.from",function(a){return a?a:function(b,c,d){c=null!=c?c:function(h){return h};
var e=[],f="undefined"!=typeof Symbol&&Symbol.iterator&&b[Symbol.iterator];if("function"==typeof f){b=f.call(b);for(var g=0;!(f=b.next()).done;)e.push(c.call(d,f.value,g++))}else for(f=b.length,g=0;g<f;g++)e.push(c.call(d,b[g],g));return e}});
r("Number.isNaN",function(a){return a?a:function(b){return"number"===typeof b&&isNaN(b)}});
r("Number.MAX_SAFE_INTEGER",function(){return 9007199254740991});
r("Object.is",function(a){return a?a:function(b,c){return b===c?0!==b||1/b===1/c:b!==b&&c!==c}});
r("Array.prototype.includes",function(a){return a?a:function(b,c){var d=this;d instanceof String&&(d=String(d));var e=d.length;c=c||0;for(0>c&&(c=Math.max(c+e,0));c<e;c++){var f=d[c];if(f===b||Object.is(f,b))return!0}return!1}});
r("String.prototype.includes",function(a){return a?a:function(b,c){return-1!==Ga(this,b,"includes").indexOf(b,c||0)}});
var B=this||self;function C(a,b){a=a.split(".");b=b||B;for(var c=0;c<a.length;c++)if(b=b[a[c]],null==b)return null;return b}
function Ja(){}
function Ka(a){var b=typeof a;b="object"!=b?b:a?Array.isArray(a)?"array":b:"null";return"array"==b||"object"==b&&"number"==typeof a.length}
function La(a){var b=typeof a;return"object"==b&&null!=a||"function"==b}
function Ma(a){return Object.prototype.hasOwnProperty.call(a,Na)&&a[Na]||(a[Na]=++Oa)}
var Na="closure_uid_"+(1E9*Math.random()>>>0),Oa=0;function Pa(a,b,c){return a.call.apply(a.bind,arguments)}
function Qa(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var e=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(e,d);return a.apply(b,e)}}return function(){return a.apply(b,arguments)}}
function Ra(a,b,c){Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?Ra=Pa:Ra=Qa;return Ra.apply(null,arguments)}
function D(a,b){a=a.split(".");var c=B;a[0]in c||"undefined"==typeof c.execScript||c.execScript("var "+a[0]);for(var d;a.length&&(d=a.shift());)a.length||void 0===b?c[d]&&c[d]!==Object.prototype[d]?c=c[d]:c=c[d]={}:c[d]=b}
function E(a,b){function c(){}
c.prototype=b.prototype;a.N=b.prototype;a.prototype=new c;a.prototype.constructor=a;a.Mb=function(d,e,f){for(var g=Array(arguments.length-2),h=2;h<arguments.length;h++)g[h-2]=arguments[h];return b.prototype[e].apply(d,g)}}
function Sa(a){return a}
;function Ta(a,b){if(Error.captureStackTrace)Error.captureStackTrace(this,Ta);else{var c=Error().stack;c&&(this.stack=c)}a&&(this.message=String(a));void 0!==b&&(this.hb=b)}
E(Ta,Error);Ta.prototype.name="CustomError";function Ua(a){a=a.url;var b=/[?&]dsh=1(&|$)/.test(a);this.j=!b&&/[?&]ae=1(&|$)/.test(a);this.l=!b&&/[?&]ae=2(&|$)/.test(a);if((this.h=/[?&]adurl=([^&]*)/.exec(a))&&this.h[1]){try{var c=decodeURIComponent(this.h[1])}catch(d){c=null}this.i=c}}
;function Va(a){var b=!1,c;return function(){b||(c=a(),b=!0);return c}}
;var Wa=Array.prototype.indexOf?function(a,b){return Array.prototype.indexOf.call(a,b,void 0)}:function(a,b){if("string"===typeof a)return"string"!==typeof b||1!=b.length?-1:a.indexOf(b,0);
for(var c=0;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},F=Array.prototype.forEach?function(a,b,c){Array.prototype.forEach.call(a,b,c)}:function(a,b,c){for(var d=a.length,e="string"===typeof a?a.split(""):a,f=0;f<d;f++)f in e&&b.call(c,e[f],f,a)},Xa=Array.prototype.reduce?function(a,b,c){return Array.prototype.reduce.call(a,b,c)}:function(a,b,c){var d=c;
F(a,function(e,f){d=b.call(void 0,d,e,f,a)});
return d};
function Ya(a,b){b=Wa(a,b);var c;(c=0<=b)&&Array.prototype.splice.call(a,b,1);return c}
function Za(a){return Array.prototype.concat.apply([],arguments)}
function $a(a){var b=a.length;if(0<b){for(var c=Array(b),d=0;d<b;d++)c[d]=a[d];return c}return[]}
function ab(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(Ka(d)){var e=a.length||0,f=d.length||0;a.length=e+f;for(var g=0;g<f;g++)a[e+g]=d[g]}else a.push(d)}}
;function bb(a,b){for(var c in a)b.call(void 0,a[c],c,a)}
function cb(a){var b=db,c;for(c in b)if(a.call(void 0,b[c],c,b))return c}
function eb(a,b){for(var c in a)if(!(c in b)||a[c]!==b[c])return!1;for(var d in b)if(!(d in a))return!1;return!0}
function fb(a){if(!a||"object"!==typeof a)return a;if("function"===typeof a.clone)return a.clone();if("undefined"!==typeof Map&&a instanceof Map)return new Map(a);if("undefined"!==typeof Set&&a instanceof Set)return new Set(a);var b=Array.isArray(a)?[]:"function"!==typeof ArrayBuffer||"function"!==typeof ArrayBuffer.isView||!ArrayBuffer.isView(a)||a instanceof DataView?{}:new a.constructor(a.length),c;for(c in a)b[c]=fb(a[c]);return b}
var gb="constructor hasOwnProperty isPrototypeOf propertyIsEnumerable toLocaleString toString valueOf".split(" ");function hb(a,b){for(var c,d,e=1;e<arguments.length;e++){d=arguments[e];for(c in d)a[c]=d[c];for(var f=0;f<gb.length;f++)c=gb[f],Object.prototype.hasOwnProperty.call(d,c)&&(a[c]=d[c])}}
;var ib;function jb(){}
function kb(a){return new jb(lb,a)}
var lb={};kb("");var mb=String.prototype.trim?function(a){return a.trim()}:function(a){return/^[\s\xa0]*([\s\S]*?)[\s\xa0]*$/.exec(a)[1]},nb=/&/g,ob=/</g,pb=/>/g,qb=/"/g,rb=/'/g,sb=/\x00/g,tb=/[\x00&<>"']/;function ub(){var a=B.navigator;return a&&(a=a.userAgent)?a:""}
function G(a){return-1!=ub().indexOf(a)}
;function vb(){return(G("Chrome")||G("CriOS"))&&!G("Edge")||G("Silk")}
;var wb={};function xb(a){this.h=wb===wb?a:""}
xb.prototype.toString=function(){return this.h.toString()};var yb=RegExp("^(?:([^:/?#.]+):)?(?://(?:([^\\\\/?#]*)@)?([^\\\\/?#]*?)(?::([0-9]+))?(?=[\\\\/?#]|$))?([^?#]+)?(?:\\?([^#]*))?(?:#([\\s\\S]*))?$");function zb(a){return a?decodeURI(a):a}
function Ab(a){return zb(a.match(yb)[3]||null)}
function Bb(a){var b=a.match(yb);a=b[1];var c=b[2],d=b[3];b=b[4];var e="";a&&(e+=a+":");d&&(e+="//",c&&(e+=c+"@"),e+=d,b&&(e+=":"+b));return e}
function Cb(a,b,c){if(Array.isArray(b))for(var d=0;d<b.length;d++)Cb(a,String(b[d]),c);else null!=b&&c.push(a+(""===b?"":"="+encodeURIComponent(String(b))))}
function Db(a){var b=[],c;for(c in a)Cb(c,a[c],b);return b.join("&")}
var Eb=/#|$/;function Fb(a,b){var c=a.search(Eb);a:{var d=0;for(var e=b.length;0<=(d=a.indexOf(b,d))&&d<c;){var f=a.charCodeAt(d-1);if(38==f||63==f)if(f=a.charCodeAt(d+e),!f||61==f||38==f||35==f)break a;d+=e+1}d=-1}if(0>d)return null;e=a.indexOf("&",d);if(0>e||e>c)e=c;d+=b.length+1;return decodeURIComponent(a.substr(d,e-d).replace(/\+/g," "))}
;function Gb(){return G("iPhone")&&!G("iPod")&&!G("iPad")}
;function Hb(a){Hb[" "](a);return a}
Hb[" "]=Ja;var Ib=G("Opera"),Jb=G("Trident")||G("MSIE"),Kb=G("Edge"),Lb=G("Gecko")&&!(-1!=ub().toLowerCase().indexOf("webkit")&&!G("Edge"))&&!(G("Trident")||G("MSIE"))&&!G("Edge"),Nb=-1!=ub().toLowerCase().indexOf("webkit")&&!G("Edge");function Ob(){var a=B.document;return a?a.documentMode:void 0}
var Pb;a:{var Qb="",Rb=function(){var a=ub();if(Lb)return/rv:([^\);]+)(\)|;)/.exec(a);if(Kb)return/Edge\/([\d\.]+)/.exec(a);if(Jb)return/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/.exec(a);if(Nb)return/WebKit\/(\S+)/.exec(a);if(Ib)return/(?:Version)[ \/]?(\S+)/.exec(a)}();
Rb&&(Qb=Rb?Rb[1]:"");if(Jb){var Sb=Ob();if(null!=Sb&&Sb>parseFloat(Qb)){Pb=String(Sb);break a}}Pb=Qb}var Tb=Pb,Ub;if(B.document&&Jb){var Vb=Ob();Ub=Vb?Vb:parseInt(Tb,10)||void 0}else Ub=void 0;var Wb=Ub;var Xb=Gb()||G("iPod"),Yb=G("iPad");!G("Android")||vb();vb();var Zb=G("Safari")&&!(vb()||G("Coast")||G("Opera")||G("Edge")||G("Edg/")||G("OPR")||G("Firefox")||G("FxiOS")||G("Silk")||G("Android"))&&!(Gb()||G("iPad")||G("iPod"));var $b={},ac=null;
function bc(a,b){Ka(a);void 0===b&&(b=0);if(!ac){ac={};for(var c="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".split(""),d=["+/=","+/","-_=","-_.","-_"],e=0;5>e;e++){var f=c.concat(d[e].split(""));$b[e]=f;for(var g=0;g<f.length;g++){var h=f[g];void 0===ac[h]&&(ac[h]=g)}}}b=$b[b];c=Array(Math.floor(a.length/3));d=b[64]||"";for(e=f=0;f<a.length-2;f+=3){var k=a[f],l=a[f+1];h=a[f+2];g=b[k>>2];k=b[(k&3)<<4|l>>4];l=b[(l&15)<<2|h>>6];h=b[h&63];c[e++]=""+g+k+l+h}g=0;h=d;switch(a.length-
f){case 2:g=a[f+1],h=b[(g&15)<<2]||d;case 1:a=a[f],c[e]=""+b[a>>2]+b[(a&3)<<4|g>>4]+h+d}return c.join("")}
;var cc="function"===typeof Uint8Array;var dc="function"===typeof Symbol&&"symbol"===typeof Symbol()?Symbol(void 0):void 0;function ec(a){Object.isFrozen(a)||(dc?a[dc]|=1:void 0!==a.h?a.h|=1:Object.defineProperties(a,{h:{value:1,configurable:!0,writable:!0,enumerable:!1}}));return a}
;function fc(a){return null!==a&&"object"===typeof a&&!Array.isArray(a)&&a.constructor===Object}
var gc;function hc(a){switch(typeof a){case "number":return isFinite(a)?a:String(a);case "object":if(a&&!Array.isArray(a)&&cc&&null!=a&&a instanceof Uint8Array)return bc(a)}return a}
;function ic(a,b){if(null!=a){if(Array.isArray(a))a=jc(a,b);else if(fc(a)){var c={},d;for(d in a)c[d]=ic(a[d],b);a=c}else a=b(a);return a}}
function jc(a,b){for(var c=a.slice(),d=0;d<c.length;d++)c[d]=ic(c[d],b);if(Array.isArray(a)){var e;dc?e=a[dc]:e=a.h;a=!!((null==e?0:e)&1)}else a=!1;a&&ec(c);return c}
function kc(a){if(a&&"object"==typeof a&&a.toJSON)return a.toJSON();a=hc(a);return Array.isArray(a)?jc(a,kc):a}
function lc(a){return cc&&null!=a&&a instanceof Uint8Array?new Uint8Array(a):a}
;var mc;function H(a,b,c){var d=mc;mc=null;a||(a=d);d=this.constructor.Rb;a||(a=d?[d]:[]);this.j=(d?0:-1)-(this.constructor.Qb||0);this.h=void 0;this.H=a;a:{d=this.H.length;a=d-1;if(d&&(d=this.H[a],fc(d))){this.l=a-this.j;this.i=d;break a}void 0!==b&&-1<b?(this.l=Math.max(b,a+1-this.j),this.i=void 0):this.l=Number.MAX_VALUE}if(c)for(b=0;b<c.length;b++)if(a=c[b],a<this.l)a+=this.j,(d=this.H[a])?Array.isArray(d)&&ec(d):this.H[a]=nc;else{d=this.i||(this.i=this.H[this.l+this.j]={});var e=d[a];e?Array.isArray(e)&&
ec(e):d[a]=nc}}
var nc=Object.freeze(ec([]));function oc(a,b,c){return-1===b?null:b>=a.l?a.i?a.i[b]:void 0:(void 0===c?0:c)&&a.i&&(c=a.i[b],null!=c)?c:a.H[b+a.j]}
function pc(a,b,c){c=void 0===c?!1:c;var d=oc(a,b,c);null==d&&(d=nc);d===nc&&(d=ec(d.slice()),I(a,b,d,c));return d}
function I(a,b,c,d){b<a.l&&(void 0===d||!d)?a.H[b+a.j]=c:(a.i||(a.i=a.H[a.l+a.j]={}))[b]=c;return a}
function qc(a,b){for(var c=0,d=0;d<b.length;d++){var e=b[d];null!=oc(a,e)&&(0!==c&&I(a,c,void 0,!1),c=e)}return c}
function rc(a,b,c,d,e){if(-1===c)return null;a.h||(a.h={});var f=a.h[c];if(f)return f;e=oc(a,c,void 0===e?!1:e);if(null==e&&!d)return f;b=new b(e);return a.h[c]=b}
function sc(a,b,c,d){a.h||(a.h={});var e=a.h[c];if(!e){d=pc(a,c,void 0===d?!1:d);e=[];for(var f=0;f<d.length;f++)e[f]=new b(d[f]);a.h[c]=e}return e}
function tc(a,b,c,d){a.h||(a.h={});var e=c?c.H:c;a.h[b]=c;return I(a,b,e,void 0===d?!1:d)}
function uc(a,b,c,d){var e=sc(a,c,b,void 0===e?!1:e);c=d?d:new c;a=pc(a,b);e.push(c);a.push(c.H)}
H.prototype.toJSON=function(){var a=this.H;return gc?a:jc(a,kc)};
function vc(a,b){return hc(b)}
H.prototype.toString=function(){return this.H.toString()};
H.prototype.clone=function(){var a=this.constructor,b;mc=b=jc(this.H,lc);a=new a(b);mc=null;wc(a,this);return a};
function wc(a,b){b.m&&(a.m=b.m.slice());var c=b.h;if(c){b=b.i;for(var d in c){var e=c[d];if(e){var f=!(!b||!b[d]),g=+d;if(Array.isArray(e)){if(e.length)for(f=sc(a,e[0].constructor,g,f),g=0;g<Math.min(f.length,e.length);g++)wc(f[g],e[g])}else(f=rc(a,e.constructor,g,void 0,f))&&wc(f,e)}}}}
;function xc(a,b){var c=this.h;if(this.isRepeated){var d=!0;d=void 0===d?!1:d;if(b){var e=ec([]);for(var f=0;f<b.length;f++)e[f]=b[f].H;a.h||(a.h={});a.h[c]=b}else a.h&&(a.h[c]=void 0),e=nc;a=I(a,c,e,d)}else a=tc(a,c,b,!0);return a}
;var yc=window;kb("csi.gstatic.com");kb("googleads.g.doubleclick.net");kb("partner.googleadservices.com");kb("pubads.g.doubleclick.net");kb("securepubads.g.doubleclick.net");kb("tpc.googlesyndication.com");/*

 SPDX-License-Identifier: Apache-2.0
*/
function zc(a,b){this.width=a;this.height=b}
n=zc.prototype;n.clone=function(){return new zc(this.width,this.height)};
n.aspectRatio=function(){return this.width/this.height};
n.isEmpty=function(){return!(this.width*this.height)};
n.ceil=function(){this.width=Math.ceil(this.width);this.height=Math.ceil(this.height);return this};
n.floor=function(){this.width=Math.floor(this.width);this.height=Math.floor(this.height);return this};
n.round=function(){this.width=Math.round(this.width);this.height=Math.round(this.height);return this};
n.scale=function(a,b){this.width*=a;this.height*="number"===typeof b?b:a;return this};function Ac(){var a=document;var b="IFRAME";"application/xhtml+xml"===a.contentType&&(b=b.toLowerCase());return a.createElement(b)}
function Bc(a,b){for(var c=0;a;){if(b(a))return a;a=a.parentNode;c++}return null}
;function Cc(a){var b=Dc;if(b)for(var c in b)Object.prototype.hasOwnProperty.call(b,c)&&a(b[c],c,b)}
function Ec(){var a=[];Cc(function(b){a.push(b)});
return a}
var Dc={ub:"allow-forms",vb:"allow-modals",wb:"allow-orientation-lock",xb:"allow-pointer-lock",yb:"allow-popups",zb:"allow-popups-to-escape-sandbox",Ab:"allow-presentation",Bb:"allow-same-origin",Cb:"allow-scripts",Db:"allow-top-navigation",Eb:"allow-top-navigation-by-user-activation"},Fc=Va(function(){return Ec()});
function Gc(){var a=Hc(),b={};F(Fc(),function(c){a.sandbox&&a.sandbox.supports&&a.sandbox.supports(c)&&(b[c]=!0)});
return b}
function Hc(){var a=void 0===a?document:a;return a.createElement("iframe")}
;var Ic=(new Date).getTime();var Jc=new function(a,b){this.flag=a;this.defaultValue=void 0===b?!1:b}(1959);function Kc(a){if(!a)return"";if(/^about:(?:blank|srcdoc)$/.test(a))return window.origin||"";a=a.split("#")[0].split("?")[0];a=a.toLowerCase();0==a.indexOf("//")&&(a=window.location.protocol+a);/^[\w\-]*:\/\//.test(a)||(a=window.location.href);var b=a.substring(a.indexOf("://")+3),c=b.indexOf("/");-1!=c&&(b=b.substring(0,c));c=a.substring(0,a.indexOf("://"));if(!c)throw Error("URI is missing protocol: "+a);if("http"!==c&&"https"!==c&&"chrome-extension"!==c&&"moz-extension"!==c&&"file"!==c&&"android-app"!==
c&&"chrome-search"!==c&&"chrome-untrusted"!==c&&"chrome"!==c&&"app"!==c&&"devtools"!==c)throw Error("Invalid URI scheme in origin: "+c);a="";var d=b.indexOf(":");if(-1!=d){var e=b.substring(d+1);b=b.substring(0,d);if("http"===c&&"80"!==e||"https"===c&&"443"!==e)a=":"+e}return c+"://"+b+a}
;function Lc(){function a(){e[0]=1732584193;e[1]=4023233417;e[2]=2562383102;e[3]=271733878;e[4]=3285377520;m=l=0}
function b(p){for(var u=g,q=0;64>q;q+=4)u[q/4]=p[q]<<24|p[q+1]<<16|p[q+2]<<8|p[q+3];for(q=16;80>q;q++)p=u[q-3]^u[q-8]^u[q-14]^u[q-16],u[q]=(p<<1|p>>>31)&4294967295;p=e[0];var x=e[1],y=e[2],A=e[3],M=e[4];for(q=0;80>q;q++){if(40>q)if(20>q){var O=A^x&(y^A);var P=1518500249}else O=x^y^A,P=1859775393;else 60>q?(O=x&y|A&(x|y),P=2400959708):(O=x^y^A,P=3395469782);O=((p<<5|p>>>27)&4294967295)+O+M+P+u[q]&4294967295;M=A;A=y;y=(x<<30|x>>>2)&4294967295;x=p;p=O}e[0]=e[0]+p&4294967295;e[1]=e[1]+x&4294967295;e[2]=
e[2]+y&4294967295;e[3]=e[3]+A&4294967295;e[4]=e[4]+M&4294967295}
function c(p,u){if("string"===typeof p){p=unescape(encodeURIComponent(p));for(var q=[],x=0,y=p.length;x<y;++x)q.push(p.charCodeAt(x));p=q}u||(u=p.length);q=0;if(0==l)for(;q+64<u;)b(p.slice(q,q+64)),q+=64,m+=64;for(;q<u;)if(f[l++]=p[q++],m++,64==l)for(l=0,b(f);q+64<u;)b(p.slice(q,q+64)),q+=64,m+=64}
function d(){var p=[],u=8*m;56>l?c(h,56-l):c(h,64-(l-56));for(var q=63;56<=q;q--)f[q]=u&255,u>>>=8;b(f);for(q=u=0;5>q;q++)for(var x=24;0<=x;x-=8)p[u++]=e[q]>>x&255;return p}
for(var e=[],f=[],g=[],h=[128],k=1;64>k;++k)h[k]=0;var l,m;a();return{reset:a,update:c,digest:d,jb:function(){for(var p=d(),u="",q=0;q<p.length;q++)u+="0123456789ABCDEF".charAt(Math.floor(p[q]/16))+"0123456789ABCDEF".charAt(p[q]%16);return u}}}
;function Mc(a,b,c){var d=String(B.location.href);return d&&a&&b?[b,Nc(Kc(d),a,c||null)].join(" "):null}
function Nc(a,b,c){var d=[],e=[];if(1==(Array.isArray(c)?2:1))return e=[b,a],F(d,function(h){e.push(h)}),Oc(e.join(" "));
var f=[],g=[];F(c,function(h){g.push(h.key);f.push(h.value)});
c=Math.floor((new Date).getTime()/1E3);e=0==f.length?[c,b,a]:[f.join(":"),c,b,a];F(d,function(h){e.push(h)});
a=Oc(e.join(" "));a=[c,a];0==g.length||a.push(g.join(""));return a.join("_")}
function Oc(a){var b=Lc();b.update(a);return b.jb().toLowerCase()}
;var Pc={};function Qc(a){this.h=a||{cookie:""}}
n=Qc.prototype;n.isEnabled=function(){if(!B.navigator.cookieEnabled)return!1;if(!this.isEmpty())return!0;this.set("TESTCOOKIESENABLED","1",{Ca:60});if("1"!==this.get("TESTCOOKIESENABLED"))return!1;this.remove("TESTCOOKIESENABLED");return!0};
n.set=function(a,b,c){var d=!1;if("object"===typeof c){var e=c.Ub;d=c.secure||!1;var f=c.domain||void 0;var g=c.path||void 0;var h=c.Ca}if(/[;=\s]/.test(a))throw Error('Invalid cookie name "'+a+'"');if(/[;\r\n]/.test(b))throw Error('Invalid cookie value "'+b+'"');void 0===h&&(h=-1);c=f?";domain="+f:"";g=g?";path="+g:"";d=d?";secure":"";h=0>h?"":0==h?";expires="+(new Date(1970,1,1)).toUTCString():";expires="+(new Date(Date.now()+1E3*h)).toUTCString();this.h.cookie=a+"="+b+c+g+h+d+(null!=e?";samesite="+
e:"")};
n.get=function(a,b){for(var c=a+"=",d=(this.h.cookie||"").split(";"),e=0,f;e<d.length;e++){f=mb(d[e]);if(0==f.lastIndexOf(c,0))return f.substr(c.length);if(f==a)return""}return b};
n.remove=function(a,b,c){var d=void 0!==this.get(a);this.set(a,"",{Ca:0,path:b,domain:c});return d};
n.isEmpty=function(){return!this.h.cookie};
n.clear=function(){for(var a=(this.h.cookie||"").split(";"),b=[],c=[],d,e,f=0;f<a.length;f++)e=mb(a[f]),d=e.indexOf("="),-1==d?(b.push(""),c.push(e)):(b.push(e.substring(0,d)),c.push(e.substring(d+1)));for(a=b.length-1;0<=a;a--)this.remove(b[a])};
var Rc=new Qc("undefined"==typeof document?null:document);function Sc(a){return!!Pc.FPA_SAMESITE_PHASE2_MOD||!(void 0===a||!a)}
function Tc(a,b,c,d){(a=B[a])||(a=(new Qc(document)).get(b));return a?Mc(a,c,d):null}
function Uc(a){var b=void 0===b?!1:b;var c=Kc(String(B.location.href)),d=[];var e=b;e=void 0===e?!1:e;var f=B.__SAPISID||B.__APISID||B.__3PSAPISID||B.__OVERRIDE_SID;Sc(e)&&(f=f||B.__1PSAPISID);if(f)e=!0;else{var g=new Qc(document);f=g.get("SAPISID")||g.get("APISID")||g.get("__Secure-3PAPISID")||g.get("SID");Sc(e)&&(f=f||g.get("__Secure-1PAPISID"));e=!!f}e&&(e=(c=0==c.indexOf("https:")||0==c.indexOf("chrome-extension:")||0==c.indexOf("moz-extension:"))?B.__SAPISID:B.__APISID,e||(e=new Qc(document),
e=e.get(c?"SAPISID":"APISID")||e.get("__Secure-3PAPISID")),(e=e?Mc(e,c?"SAPISIDHASH":"APISIDHASH",a):null)&&d.push(e),c&&Sc(b)&&((b=Tc("__1PSAPISID","__Secure-1PAPISID","SAPISID1PHASH",a))&&d.push(b),(a=Tc("__3PSAPISID","__Secure-3PAPISID","SAPISID3PHASH",a))&&d.push(a)));return 0==d.length?null:d.join(" ")}
;function Vc(){this.l=this.l;this.v=this.v}
Vc.prototype.l=!1;Vc.prototype.dispose=function(){this.l||(this.l=!0,this.fa())};
Vc.prototype.fa=function(){if(this.v)for(;this.v.length;)this.v.shift()()};function Wc(a,b){this.type=a;this.h=this.target=b;this.defaultPrevented=this.j=!1}
Wc.prototype.stopPropagation=function(){this.j=!0};
Wc.prototype.preventDefault=function(){this.defaultPrevented=!0};function Xc(a){var b=C("window.location.href");null==a&&(a='Unknown Error of type "null/undefined"');if("string"===typeof a)return{message:a,name:"Unknown error",lineNumber:"Not available",fileName:b,stack:"Not available"};var c=!1;try{var d=a.lineNumber||a.line||"Not available"}catch(g){d="Not available",c=!0}try{var e=a.fileName||a.filename||a.sourceURL||B.$googDebugFname||b}catch(g){e="Not available",c=!0}b=Yc(a);if(!(!c&&a.lineNumber&&a.fileName&&a.stack&&a.message&&a.name)){c=a.message;if(null==
c){if(a.constructor&&a.constructor instanceof Function){if(a.constructor.name)c=a.constructor.name;else if(c=a.constructor,Zc[c])c=Zc[c];else{c=String(c);if(!Zc[c]){var f=/function\s+([^\(]+)/m.exec(c);Zc[c]=f?f[1]:"[Anonymous]"}c=Zc[c]}c='Unknown Error of type "'+c+'"'}else c="Unknown Error of unknown type";"function"===typeof a.toString&&Object.prototype.toString!==a.toString&&(c+=": "+a.toString())}return{message:c,name:a.name||"UnknownError",lineNumber:d,fileName:e,stack:b||"Not available"}}a.stack=
b;return{message:a.message,name:a.name,lineNumber:a.lineNumber,fileName:a.fileName,stack:a.stack}}
function Yc(a,b){b||(b={});b[$c(a)]=!0;var c=a.stack||"";(a=a.hb)&&!b[$c(a)]&&(c+="\nCaused by: ",a.stack&&0==a.stack.indexOf(a.toString())||(c+="string"===typeof a?a:a.message+"\n"),c+=Yc(a,b));return c}
function $c(a){var b="";"function"===typeof a.toString&&(b=""+a);return b+a.stack}
var Zc={};var ad=function(){if(!B.addEventListener||!Object.defineProperty)return!1;var a=!1,b=Object.defineProperty({},"passive",{get:function(){a=!0}});
try{B.addEventListener("test",Ja,b),B.removeEventListener("test",Ja,b)}catch(c){}return a}();function bd(a,b){Wc.call(this,a?a.type:"");this.relatedTarget=this.h=this.target=null;this.button=this.screenY=this.screenX=this.clientY=this.clientX=0;this.key="";this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.altKey=this.ctrlKey=!1;this.state=null;this.pointerId=0;this.pointerType="";this.i=null;a&&this.init(a,b)}
E(bd,Wc);var cd={2:"touch",3:"pen",4:"mouse"};
bd.prototype.init=function(a,b){var c=this.type=a.type,d=a.changedTouches&&a.changedTouches.length?a.changedTouches[0]:null;this.target=a.target||a.srcElement;this.h=b;if(b=a.relatedTarget){if(Lb){a:{try{Hb(b.nodeName);var e=!0;break a}catch(f){}e=!1}e||(b=null)}}else"mouseover"==c?b=a.fromElement:"mouseout"==c&&(b=a.toElement);this.relatedTarget=b;d?(this.clientX=void 0!==d.clientX?d.clientX:d.pageX,this.clientY=void 0!==d.clientY?d.clientY:d.pageY,this.screenX=d.screenX||0,this.screenY=d.screenY||
0):(this.clientX=void 0!==a.clientX?a.clientX:a.pageX,this.clientY=void 0!==a.clientY?a.clientY:a.pageY,this.screenX=a.screenX||0,this.screenY=a.screenY||0);this.button=a.button;this.keyCode=a.keyCode||0;this.key=a.key||"";this.charCode=a.charCode||("keypress"==c?a.keyCode:0);this.ctrlKey=a.ctrlKey;this.altKey=a.altKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey;this.pointerId=a.pointerId||0;this.pointerType="string"===typeof a.pointerType?a.pointerType:cd[a.pointerType]||"";this.state=a.state;
this.i=a;a.defaultPrevented&&bd.N.preventDefault.call(this)};
bd.prototype.stopPropagation=function(){bd.N.stopPropagation.call(this);this.i.stopPropagation?this.i.stopPropagation():this.i.cancelBubble=!0};
bd.prototype.preventDefault=function(){bd.N.preventDefault.call(this);var a=this.i;a.preventDefault?a.preventDefault():a.returnValue=!1};var dd="closure_listenable_"+(1E6*Math.random()|0);var ed=0;function fd(a,b,c,d,e){this.listener=a;this.proxy=null;this.src=b;this.type=c;this.capture=!!d;this.pa=e;this.key=++ed;this.ha=this.la=!1}
function gd(a){a.ha=!0;a.listener=null;a.proxy=null;a.src=null;a.pa=null}
;function hd(a){this.src=a;this.listeners={};this.h=0}
hd.prototype.add=function(a,b,c,d,e){var f=a.toString();a=this.listeners[f];a||(a=this.listeners[f]=[],this.h++);var g=id(a,b,d,e);-1<g?(b=a[g],c||(b.la=!1)):(b=new fd(b,this.src,f,!!d,e),b.la=c,a.push(b));return b};
hd.prototype.remove=function(a,b,c,d){a=a.toString();if(!(a in this.listeners))return!1;var e=this.listeners[a];b=id(e,b,c,d);return-1<b?(gd(e[b]),Array.prototype.splice.call(e,b,1),0==e.length&&(delete this.listeners[a],this.h--),!0):!1};
function jd(a,b){var c=b.type;c in a.listeners&&Ya(a.listeners[c],b)&&(gd(b),0==a.listeners[c].length&&(delete a.listeners[c],a.h--))}
function id(a,b,c,d){for(var e=0;e<a.length;++e){var f=a[e];if(!f.ha&&f.listener==b&&f.capture==!!c&&f.pa==d)return e}return-1}
;var kd="closure_lm_"+(1E6*Math.random()|0),ld={},md=0;function nd(a,b,c,d,e){if(d&&d.once)od(a,b,c,d,e);else if(Array.isArray(b))for(var f=0;f<b.length;f++)nd(a,b[f],c,d,e);else c=pd(c),a&&a[dd]?a.Y(b,c,La(d)?!!d.capture:!!d,e):qd(a,b,c,!1,d,e)}
function qd(a,b,c,d,e,f){if(!b)throw Error("Invalid event type");var g=La(e)?!!e.capture:!!e,h=rd(a);h||(a[kd]=h=new hd(a));c=h.add(b,c,d,g,f);if(!c.proxy){d=sd();c.proxy=d;d.src=a;d.listener=c;if(a.addEventListener)ad||(e=g),void 0===e&&(e=!1),a.addEventListener(b.toString(),d,e);else if(a.attachEvent)a.attachEvent(td(b.toString()),d);else if(a.addListener&&a.removeListener)a.addListener(d);else throw Error("addEventListener and attachEvent are unavailable.");md++}}
function sd(){function a(c){return b.call(a.src,a.listener,c)}
var b=ud;return a}
function od(a,b,c,d,e){if(Array.isArray(b))for(var f=0;f<b.length;f++)od(a,b[f],c,d,e);else c=pd(c),a&&a[dd]?a.h.add(String(b),c,!0,La(d)?!!d.capture:!!d,e):qd(a,b,c,!0,d,e)}
function vd(a,b,c,d,e){if(Array.isArray(b))for(var f=0;f<b.length;f++)vd(a,b[f],c,d,e);else(d=La(d)?!!d.capture:!!d,c=pd(c),a&&a[dd])?a.h.remove(String(b),c,d,e):a&&(a=rd(a))&&(b=a.listeners[b.toString()],a=-1,b&&(a=id(b,c,d,e)),(c=-1<a?b[a]:null)&&wd(c))}
function wd(a){if("number"!==typeof a&&a&&!a.ha){var b=a.src;if(b&&b[dd])jd(b.h,a);else{var c=a.type,d=a.proxy;b.removeEventListener?b.removeEventListener(c,d,a.capture):b.detachEvent?b.detachEvent(td(c),d):b.addListener&&b.removeListener&&b.removeListener(d);md--;(c=rd(b))?(jd(c,a),0==c.h&&(c.src=null,b[kd]=null)):gd(a)}}}
function td(a){return a in ld?ld[a]:ld[a]="on"+a}
function ud(a,b){if(a.ha)a=!0;else{b=new bd(b,this);var c=a.listener,d=a.pa||a.src;a.la&&wd(a);a=c.call(d,b)}return a}
function rd(a){a=a[kd];return a instanceof hd?a:null}
var xd="__closure_events_fn_"+(1E9*Math.random()>>>0);function pd(a){if("function"===typeof a)return a;a[xd]||(a[xd]=function(b){return a.handleEvent(b)});
return a[xd]}
;function J(){Vc.call(this);this.h=new hd(this);this.va=this;this.I=null}
E(J,Vc);J.prototype[dd]=!0;J.prototype.addEventListener=function(a,b,c,d){nd(this,a,b,c,d)};
J.prototype.removeEventListener=function(a,b,c,d){vd(this,a,b,c,d)};
function yd(a,b){var c=a.I;if(c){var d=[];for(var e=1;c;c=c.I)d.push(c),++e}a=a.va;c=b.type||b;"string"===typeof b?b=new Wc(b,a):b instanceof Wc?b.target=b.target||a:(e=b,b=new Wc(c,a),hb(b,e));e=!0;if(d)for(var f=d.length-1;!b.j&&0<=f;f--){var g=b.h=d[f];e=zd(g,c,!0,b)&&e}b.j||(g=b.h=a,e=zd(g,c,!0,b)&&e,b.j||(e=zd(g,c,!1,b)&&e));if(d)for(f=0;!b.j&&f<d.length;f++)g=b.h=d[f],e=zd(g,c,!1,b)&&e}
J.prototype.fa=function(){J.N.fa.call(this);if(this.h){var a=this.h,b=0,c;for(c in a.listeners){for(var d=a.listeners[c],e=0;e<d.length;e++)++b,gd(d[e]);delete a.listeners[c];a.h--}}this.I=null};
J.prototype.Y=function(a,b,c,d){return this.h.add(String(a),b,!1,c,d)};
function zd(a,b,c,d){b=a.h.listeners[String(b)];if(!b)return!0;b=b.concat();for(var e=!0,f=0;f<b.length;++f){var g=b[f];if(g&&!g.ha&&g.capture==c){var h=g.listener,k=g.pa||g.src;g.la&&jd(a.h,g);e=!1!==h.call(k,d)&&e}}return e&&!d.defaultPrevented}
;function Ad(a){var b,c;J.call(this);var d=this;this.B=this.j=0;this.K=null!==a&&void 0!==a?a:{L:function(e,f){return setTimeout(e,f)},
W:clearTimeout};this.i=null!==(c=null===(b=window.navigator)||void 0===b?void 0:b.onLine)&&void 0!==c?c:!0;this.m=function(){return z(function(e){return w(e,Bd(d),0)})};
window.addEventListener("offline",this.m);window.addEventListener("online",this.m);this.B||Cd(this)}
v(Ad,J);Ad.prototype.dispose=function(){window.removeEventListener("offline",this.m);window.removeEventListener("online",this.m);this.K.W(this.B);delete Ad.h};
Ad.prototype.D=function(){return this.i};
function Cd(a){a.B=a.K.L(function(){var b;return z(function(c){if(1==c.h)return a.i?(null===(b=window.navigator)||void 0===b?0:b.onLine)?c.o(3):w(c,Bd(a),3):w(c,Bd(a),3);Cd(a);c.h=0})},3E4)}
function Bd(a,b){return a.u?a.u:a.u=new Promise(function(c){var d,e,f;return z(function(g){switch(g.h){case 1:return d=window.AbortController?new window.AbortController:void 0,e=null===d||void 0===d?void 0:d.signal,f=!1,sa(g,2,3),d&&(a.j=a.K.L(function(){d.abort()},b||2E4)),w(g,fetch("/generate_204",{method:"HEAD",
signal:e}),5);case 5:f=!0;case 3:va(g);a.u=void 0;a.j&&(a.K.W(a.j),a.j=0);f!==a.i&&(a.i=f,a.i?yd(a,"networkstatus-online"):yd(a,"networkstatus-offline"));c(f);xa(g);break;case 2:ua(g),f=!1,g.o(3)}})})}
;function Dd(){this.data_=[];this.h=-1}
Dd.prototype.set=function(a,b){b=void 0===b?!0:b;0<=a&&52>a&&0===a%1&&this.data_[a]!=b&&(this.data_[a]=b,this.h=-1)};
Dd.prototype.get=function(a){return!!this.data_[a]};
function Ed(a){-1==a.h&&(a.h=Xa(a.data_,function(b,c,d){return c?b+Math.pow(2,d):b},0));
return a.h}
;function Fd(){var a={};this.A=function(b,c){return null!=a[b]?a[b]:c}}
;function Gd(a,b){this.j=a;this.l=b;this.i=0;this.h=null}
Gd.prototype.get=function(){if(0<this.i){this.i--;var a=this.h;this.h=a.next;a.next=null}else a=this.j();return a};
function Hd(a,b){a.l(b);100>a.i&&(a.i++,b.next=a.h,a.h=b)}
;var Id;function Jd(){var a=B.MessageChannel;"undefined"===typeof a&&"undefined"!==typeof window&&window.postMessage&&window.addEventListener&&!G("Presto")&&(a=function(){var e=Ac();e.style.display="none";document.documentElement.appendChild(e);var f=e.contentWindow;e=f.document;e.open();e.close();var g="callImmediate"+Math.random(),h="file:"==f.location.protocol?"*":f.location.protocol+"//"+f.location.host;e=Ra(function(k){if(("*"==h||k.origin==h)&&k.data==g)this.port1.onmessage()},this);
f.addEventListener("message",e,!1);this.port1={};this.port2={postMessage:function(){f.postMessage(g,h)}}});
if("undefined"!==typeof a&&!G("Trident")&&!G("MSIE")){var b=new a,c={},d=c;b.port1.onmessage=function(){if(void 0!==c.next){c=c.next;var e=c.Ka;c.Ka=null;e()}};
return function(e){d.next={Ka:e};d=d.next;b.port2.postMessage(0)}}return function(e){B.setTimeout(e,0)}}
;function Kd(a){B.setTimeout(function(){throw a;},0)}
;function Ld(){this.i=this.h=null}
Ld.prototype.add=function(a,b){var c=Md.get();c.set(a,b);this.i?this.i.next=c:this.h=c;this.i=c};
Ld.prototype.remove=function(){var a=null;this.h&&(a=this.h,this.h=this.h.next,this.h||(this.i=null),a.next=null);return a};
var Md=new Gd(function(){return new Nd},function(a){return a.reset()});
function Nd(){this.next=this.scope=this.h=null}
Nd.prototype.set=function(a,b){this.h=a;this.scope=b;this.next=null};
Nd.prototype.reset=function(){this.next=this.scope=this.h=null};function Od(a,b){Pd||Qd();Rd||(Pd(),Rd=!0);Td.add(a,b)}
var Pd;function Qd(){if(B.Promise&&B.Promise.resolve){var a=B.Promise.resolve(void 0);Pd=function(){a.then(Ud)}}else Pd=function(){var b=Ud;
"function"!==typeof B.setImmediate||B.Window&&B.Window.prototype&&!G("Edge")&&B.Window.prototype.setImmediate==B.setImmediate?(Id||(Id=Jd()),Id(b)):B.setImmediate(b)}}
var Rd=!1,Td=new Ld;function Ud(){for(var a;a=Td.remove();){try{a.h.call(a.scope)}catch(b){Kd(b)}Hd(Md,a)}Rd=!1}
;function Vd(a,b){this.h=a[B.Symbol.iterator]();this.i=b;this.j=0}
Vd.prototype[Symbol.iterator]=function(){return this};
Vd.prototype.next=function(){var a=this.h.next();return{value:a.done?void 0:this.i.call(void 0,a.value,this.j++),done:a.done}};
function Wd(a,b){return new Vd(a,b)}
;function Xd(){this.blockSize=-1}
;function Yd(){this.blockSize=-1;this.blockSize=64;this.h=[];this.m=[];this.v=[];this.j=[];this.j[0]=128;for(var a=1;a<this.blockSize;++a)this.j[a]=0;this.l=this.i=0;this.reset()}
E(Yd,Xd);Yd.prototype.reset=function(){this.h[0]=1732584193;this.h[1]=4023233417;this.h[2]=2562383102;this.h[3]=271733878;this.h[4]=3285377520;this.l=this.i=0};
function Zd(a,b,c){c||(c=0);var d=a.v;if("string"===typeof b)for(var e=0;16>e;e++)d[e]=b.charCodeAt(c)<<24|b.charCodeAt(c+1)<<16|b.charCodeAt(c+2)<<8|b.charCodeAt(c+3),c+=4;else for(e=0;16>e;e++)d[e]=b[c]<<24|b[c+1]<<16|b[c+2]<<8|b[c+3],c+=4;for(e=16;80>e;e++){var f=d[e-3]^d[e-8]^d[e-14]^d[e-16];d[e]=(f<<1|f>>>31)&4294967295}b=a.h[0];c=a.h[1];var g=a.h[2],h=a.h[3],k=a.h[4];for(e=0;80>e;e++){if(40>e)if(20>e){f=h^c&(g^h);var l=1518500249}else f=c^g^h,l=1859775393;else 60>e?(f=c&g|h&(c|g),l=2400959708):
(f=c^g^h,l=3395469782);f=(b<<5|b>>>27)+f+k+l+d[e]&4294967295;k=h;h=g;g=(c<<30|c>>>2)&4294967295;c=b;b=f}a.h[0]=a.h[0]+b&4294967295;a.h[1]=a.h[1]+c&4294967295;a.h[2]=a.h[2]+g&4294967295;a.h[3]=a.h[3]+h&4294967295;a.h[4]=a.h[4]+k&4294967295}
Yd.prototype.update=function(a,b){if(null!=a){void 0===b&&(b=a.length);for(var c=b-this.blockSize,d=0,e=this.m,f=this.i;d<b;){if(0==f)for(;d<=c;)Zd(this,a,d),d+=this.blockSize;if("string"===typeof a)for(;d<b;){if(e[f]=a.charCodeAt(d),++f,++d,f==this.blockSize){Zd(this,e);f=0;break}}else for(;d<b;)if(e[f]=a[d],++f,++d,f==this.blockSize){Zd(this,e);f=0;break}}this.i=f;this.l+=b}};
Yd.prototype.digest=function(){var a=[],b=8*this.l;56>this.i?this.update(this.j,56-this.i):this.update(this.j,this.blockSize-(this.i-56));for(var c=this.blockSize-1;56<=c;c--)this.m[c]=b&255,b/=256;Zd(this,this.m);for(c=b=0;5>c;c++)for(var d=24;0<=d;d-=8)a[b]=this.h[c]>>d&255,++b;return a};var $d="StopIteration"in B?B.StopIteration:{message:"StopIteration",stack:""};function ae(){}
ae.prototype.R=function(){throw $d;};
ae.prototype.next=function(){return be};
var be={done:!0,value:void 0};function ce(a){return{value:a,done:!1}}
function de(a){if(a.done)throw $d;return a.value}
ae.prototype.J=function(){return this};function ee(a){if(a instanceof fe||a instanceof ge||a instanceof he)return a;if("function"==typeof a.R)return new fe(function(){return ie(a)});
if("function"==typeof a[Symbol.iterator])return new fe(function(){return a[Symbol.iterator]()});
if("function"==typeof a.J)return new fe(function(){return ie(a.J())});
throw Error("Not an iterator or iterable.");}
function ie(a){if(!(a instanceof ae))return a;var b=!1;return{next:function(){for(var c;!b;)try{c=a.R();break}catch(d){if(d!==$d)throw d;b=!0}return{value:c,done:b}}}}
function fe(a){this.h=a}
fe.prototype.J=function(){return new ge(this.h())};
fe.prototype[Symbol.iterator]=function(){return new he(this.h())};
fe.prototype.i=function(){return new he(this.h())};
function ge(a){this.h=a}
v(ge,ae);ge.prototype.R=function(){var a=this.h.next();if(a.done)throw $d;return a.value};
ge.prototype.next=function(){return this.h.next()};
ge.prototype[Symbol.iterator]=function(){return new he(this.h)};
ge.prototype.i=function(){return new he(this.h)};
function he(a){fe.call(this,function(){return a});
this.j=a}
v(he,fe);he.prototype.next=function(){return this.j.next()};function je(a,b){this.i={};this.h=[];this.j=this.size=0;var c=arguments.length;if(1<c){if(c%2)throw Error("Uneven number of arguments");for(var d=0;d<c;d+=2)this.set(arguments[d],arguments[d+1])}else if(a)if(a instanceof je)for(c=ke(a),d=0;d<c.length;d++)this.set(c[d],a.get(c[d]));else for(d in a)this.set(d,a[d])}
function ke(a){le(a);return a.h.concat()}
n=je.prototype;n.has=function(a){return me(this.i,a)};
n.equals=function(a,b){if(this===a)return!0;if(this.size!=a.size)return!1;b=b||ne;le(this);for(var c,d=0;c=this.h[d];d++)if(!b(this.get(c),a.get(c)))return!1;return!0};
function ne(a,b){return a===b}
n.isEmpty=function(){return 0==this.size};
n.clear=function(){this.i={};this.j=this.size=this.h.length=0};
n.remove=function(a){return this.delete(a)};
n.delete=function(a){return me(this.i,a)?(delete this.i[a],--this.size,this.j++,this.h.length>2*this.size&&le(this),!0):!1};
function le(a){if(a.size!=a.h.length){for(var b=0,c=0;b<a.h.length;){var d=a.h[b];me(a.i,d)&&(a.h[c++]=d);b++}a.h.length=c}if(a.size!=a.h.length){var e={};for(c=b=0;b<a.h.length;)d=a.h[b],me(e,d)||(a.h[c++]=d,e[d]=1),b++;a.h.length=c}}
n.get=function(a,b){return me(this.i,a)?this.i[a]:b};
n.set=function(a,b){me(this.i,a)||(this.size+=1,this.h.push(a),this.j++);this.i[a]=b};
n.forEach=function(a,b){for(var c=ke(this),d=0;d<c.length;d++){var e=c[d],f=this.get(e);a.call(b,f,e,this)}};
n.clone=function(){return new je(this)};
n.keys=function(){return ee(this.J(!0)).i()};
n.values=function(){return ee(this.J(!1)).i()};
n.entries=function(){var a=this;return Wd(this.keys(),function(b){return[b,a.get(b)]})};
n.J=function(a){le(this);var b=0,c=this.j,d=this,e=new ae;e.next=function(){if(c!=d.j)throw Error("The map has changed since the iterator was created");if(b>=d.h.length)return be;var g=d.h[b++];return ce(a?g:d.i[g])};
var f=e.next;e.R=function(){return de(f.call(e))};
return e};
function me(a,b){return Object.prototype.hasOwnProperty.call(a,b)}
;var oe=B.JSON.stringify;function pe(){var a=this;this.promise=new Promise(function(b,c){a.resolve=b;a.reject=c})}
;function qe(a){this.h=0;this.u=void 0;this.l=this.i=this.j=null;this.m=this.v=!1;if(a!=Ja)try{var b=this;a.call(void 0,function(c){re(b,2,c)},function(c){re(b,3,c)})}catch(c){re(this,3,c)}}
function se(){this.next=this.context=this.onRejected=this.i=this.h=null;this.j=!1}
se.prototype.reset=function(){this.context=this.onRejected=this.i=this.h=null;this.j=!1};
var te=new Gd(function(){return new se},function(a){a.reset()});
function ue(a,b,c){var d=te.get();d.i=a;d.onRejected=b;d.context=c;return d}
qe.prototype.then=function(a,b,c){return ve(this,"function"===typeof a?a:null,"function"===typeof b?b:null,c)};
qe.prototype.$goog_Thenable=!0;qe.prototype.cancel=function(a){if(0==this.h){var b=new we(a);Od(function(){xe(this,b)},this)}};
function xe(a,b){if(0==a.h)if(a.j){var c=a.j;if(c.i){for(var d=0,e=null,f=null,g=c.i;g&&(g.j||(d++,g.h==a&&(e=g),!(e&&1<d)));g=g.next)e||(f=g);e&&(0==c.h&&1==d?xe(c,b):(f?(d=f,d.next==c.l&&(c.l=d),d.next=d.next.next):ye(c),ze(c,e,3,b)))}a.j=null}else re(a,3,b)}
function Ae(a,b){a.i||2!=a.h&&3!=a.h||Be(a);a.l?a.l.next=b:a.i=b;a.l=b}
function ve(a,b,c,d){var e=ue(null,null,null);e.h=new qe(function(f,g){e.i=b?function(h){try{var k=b.call(d,h);f(k)}catch(l){g(l)}}:f;
e.onRejected=c?function(h){try{var k=c.call(d,h);void 0===k&&h instanceof we?g(h):f(k)}catch(l){g(l)}}:g});
e.h.j=a;Ae(a,e);return e.h}
qe.prototype.I=function(a){this.h=0;re(this,2,a)};
qe.prototype.O=function(a){this.h=0;re(this,3,a)};
function re(a,b,c){if(0==a.h){a===c&&(b=3,c=new TypeError("Promise cannot resolve to itself"));a.h=1;a:{var d=c,e=a.I,f=a.O;if(d instanceof qe){Ae(d,ue(e||Ja,f||null,a));var g=!0}else{if(d)try{var h=!!d.$goog_Thenable}catch(l){h=!1}else h=!1;if(h)d.then(e,f,a),g=!0;else{if(La(d))try{var k=d.then;if("function"===typeof k){Ce(d,k,e,f,a);g=!0;break a}}catch(l){f.call(a,l);g=!0;break a}g=!1}}}g||(a.u=c,a.h=b,a.j=null,Be(a),3!=b||c instanceof we||De(a,c))}}
function Ce(a,b,c,d,e){function f(k){h||(h=!0,d.call(e,k))}
function g(k){h||(h=!0,c.call(e,k))}
var h=!1;try{b.call(a,g,f)}catch(k){f(k)}}
function Be(a){a.v||(a.v=!0,Od(a.B,a))}
function ye(a){var b=null;a.i&&(b=a.i,a.i=b.next,b.next=null);a.i||(a.l=null);return b}
qe.prototype.B=function(){for(var a;a=ye(this);)ze(this,a,this.h,this.u);this.v=!1};
function ze(a,b,c,d){if(3==c&&b.onRejected&&!b.j)for(;a&&a.m;a=a.j)a.m=!1;if(b.h)b.h.j=null,Ee(b,c,d);else try{b.j?b.i.call(b.context):Ee(b,c,d)}catch(e){Fe.call(null,e)}Hd(te,b)}
function Ee(a,b,c){2==b?a.i.call(a.context,c):a.onRejected&&a.onRejected.call(a.context,c)}
function De(a,b){a.m=!0;Od(function(){a.m&&Fe.call(null,b)})}
var Fe=Kd;function we(a){Ta.call(this,a)}
E(we,Ta);we.prototype.name="cancel";function K(a){Vc.call(this);this.u=1;this.j=[];this.m=0;this.h=[];this.i={};this.B=!!a}
E(K,Vc);n=K.prototype;n.subscribe=function(a,b,c){var d=this.i[a];d||(d=this.i[a]=[]);var e=this.u;this.h[e]=a;this.h[e+1]=b;this.h[e+2]=c;this.u=e+3;d.push(e);return e};
function Ge(a,b,c){var d=He;if(a=d.i[a]){var e=d.h;(a=a.find(function(f){return e[f+1]==b&&e[f+2]==c}))&&d.ja(a)}}
n.ja=function(a){var b=this.h[a];if(b){var c=this.i[b];0!=this.m?(this.j.push(a),this.h[a+1]=Ja):(c&&Ya(c,a),delete this.h[a],delete this.h[a+1],delete this.h[a+2])}return!!b};
n.ca=function(a,b){var c=this.i[a];if(c){for(var d=Array(arguments.length-1),e=1,f=arguments.length;e<f;e++)d[e-1]=arguments[e];if(this.B)for(e=0;e<c.length;e++){var g=c[e];Ie(this.h[g+1],this.h[g+2],d)}else{this.m++;try{for(e=0,f=c.length;e<f&&!this.l;e++)g=c[e],this.h[g+1].apply(this.h[g+2],d)}finally{if(this.m--,0<this.j.length&&0==this.m)for(;c=this.j.pop();)this.ja(c)}}return 0!=e}return!1};
function Ie(a,b,c){Od(function(){a.apply(b,c)})}
n.clear=function(a){if(a){var b=this.i[a];b&&(b.forEach(this.ja,this),delete this.i[a])}else this.h.length=0,this.i={}};
n.fa=function(){K.N.fa.call(this);this.clear();this.j.length=0};function Je(a){this.h=a}
Je.prototype.set=function(a,b){void 0===b?this.h.remove(a):this.h.set(a,oe(b))};
Je.prototype.get=function(a){try{var b=this.h.get(a)}catch(c){return}if(null!==b)try{return JSON.parse(b)}catch(c){throw"Storage: Invalid value was encountered";}};
Je.prototype.remove=function(a){this.h.remove(a)};function Ke(a){this.h=a}
E(Ke,Je);function Le(a){this.data=a}
function Me(a){return void 0===a||a instanceof Le?a:new Le(a)}
Ke.prototype.set=function(a,b){Ke.N.set.call(this,a,Me(b))};
Ke.prototype.i=function(a){a=Ke.N.get.call(this,a);if(void 0===a||a instanceof Object)return a;throw"Storage: Invalid value was encountered";};
Ke.prototype.get=function(a){if(a=this.i(a)){if(a=a.data,void 0===a)throw"Storage: Invalid value was encountered";}else a=void 0;return a};function Ne(a){this.h=a}
E(Ne,Ke);Ne.prototype.set=function(a,b,c){if(b=Me(b)){if(c){if(c<Date.now()){Ne.prototype.remove.call(this,a);return}b.expiration=c}b.creation=Date.now()}Ne.N.set.call(this,a,b)};
Ne.prototype.i=function(a){var b=Ne.N.i.call(this,a);if(b){var c=b.creation,d=b.expiration;if(d&&d<Date.now()||c&&c>Date.now())Ne.prototype.remove.call(this,a);else return b}};function Oe(){}
;function Pe(){}
E(Pe,Oe);Pe.prototype[Symbol.iterator]=function(){return ee(this.J(!0)).i()};
Pe.prototype.clear=function(){var a=Array.from(this);a=t(a);for(var b=a.next();!b.done;b=a.next())this.remove(b.value)};function Qe(a){this.h=a}
E(Qe,Pe);n=Qe.prototype;n.isAvailable=function(){if(!this.h)return!1;try{return this.h.setItem("__sak","1"),this.h.removeItem("__sak"),!0}catch(a){return!1}};
n.set=function(a,b){try{this.h.setItem(a,b)}catch(c){if(0==this.h.length)throw"Storage mechanism: Storage disabled";throw"Storage mechanism: Quota exceeded";}};
n.get=function(a){a=this.h.getItem(a);if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
n.remove=function(a){this.h.removeItem(a)};
n.J=function(a){var b=0,c=this.h,d=new ae;d.next=function(){if(b>=c.length)return be;var f=c.key(b++);if(a)return ce(f);f=c.getItem(f);if("string"!==typeof f)throw"Storage mechanism: Invalid value was encountered";return ce(f)};
var e=d.next;d.R=function(){return de(e.call(d))};
return d};
n.clear=function(){this.h.clear()};
n.key=function(a){return this.h.key(a)};function Re(){var a=null;try{a=window.localStorage||null}catch(b){}this.h=a}
E(Re,Qe);function Se(a,b){this.i=a;this.h=null;var c;if(c=Jb)c=!(9<=Number(Wb));if(c){Te||(Te=new je);this.h=Te.get(a);this.h||(b?this.h=document.getElementById(b):(this.h=document.createElement("userdata"),this.h.addBehavior("#default#userData"),document.body.appendChild(this.h)),Te.set(a,this.h));try{this.h.load(this.i)}catch(d){this.h=null}}}
E(Se,Pe);var Ue={".":".2E","!":".21","~":".7E","*":".2A","'":".27","(":".28",")":".29","%":"."},Te=null;function Ve(a){return"_"+encodeURIComponent(a).replace(/[.!~*'()%]/g,function(b){return Ue[b]})}
n=Se.prototype;n.isAvailable=function(){return!!this.h};
n.set=function(a,b){this.h.setAttribute(Ve(a),b);We(this)};
n.get=function(a){a=this.h.getAttribute(Ve(a));if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
n.remove=function(a){this.h.removeAttribute(Ve(a));We(this)};
n.J=function(a){var b=0,c=this.h.XMLDocument.documentElement.attributes,d=new ae;d.next=function(){if(b>=c.length)return be;var f=c[b++];if(a)return ce(decodeURIComponent(f.nodeName.replace(/\./g,"%")).substr(1));f=f.nodeValue;if("string"!==typeof f)throw"Storage mechanism: Invalid value was encountered";return ce(f)};
var e=d.next;d.R=function(){return de(e.call(d))};
return d};
n.clear=function(){for(var a=this.h.XMLDocument.documentElement,b=a.attributes.length;0<b;b--)a.removeAttribute(a.attributes[b-1].nodeName);We(this)};
function We(a){try{a.h.save(a.i)}catch(b){throw"Storage mechanism: Quota exceeded";}}
;function Xe(a,b){this.i=a;this.h=b+"::"}
E(Xe,Pe);Xe.prototype.set=function(a,b){this.i.set(this.h+a,b)};
Xe.prototype.get=function(a){return this.i.get(this.h+a)};
Xe.prototype.remove=function(a){this.i.remove(this.h+a)};
Xe.prototype.J=function(a){var b=this.i.J(!0),c=this,d=new ae;d.next=function(){try{var f=b.R()}catch(g){if(g===$d)return be;throw g;}for(;f.substr(0,c.h.length)!=c.h;)try{f=b.R()}catch(g){if(g===$d)return be;throw g;}return ce(a?f.substr(c.h.length):c.i.get(f))};
var e=d.next;d.R=function(){return de(e.call(d))};
return d};function Ye(a){H.call(this,a)}
v(Ye,H);Ye.prototype.getKey=function(){return oc(this,1)};
Ye.prototype.X=function(){return oc(this,2===qc(this,Ze)?2:-1)};
Ye.prototype.setValue=function(a){var b=qc(this,Ze);b&&2!==b&&null!=a&&(this.h&&b in this.h&&(this.h[b]=void 0),I(this,b,void 0));return I(this,2,a)};
var Ze=[2,3,4,5,6];function $e(a){H.call(this,a)}
v($e,H);function af(a){H.call(this,a)}
v(af,H);function bf(a){H.call(this,a)}
v(bf,H);function cf(a){H.call(this,a,-1,df)}
v(cf,H);cf.prototype.getPlayerType=function(){return oc(this,36)};
cf.prototype.setHomeGroupInfo=function(a){return tc(this,81,a)};
var df=[9,66,24,32,86,100,101];function ef(a){H.call(this,a,-1,ff)}
v(ef,H);var ff=[15,26,28];function gf(a){H.call(this,a)}
v(gf,H);gf.prototype.setToken=function(a){return I(this,2,a)};function hf(a){H.call(this,a,-1,jf)}
v(hf,H);hf.prototype.setSafetyMode=function(a){return I(this,5,a)};
var jf=[12];function kf(a){H.call(this,a,-1,lf)}
v(kf,H);var lf=[12];function mf(a){H.call(this,a,421)}
v(mf,H);function nf(a){H.call(this,a)}
v(nf,H);var of=[1,2];function pf(a){H.call(this,a,-1,qf)}
v(pf,H);var qf=[3];function rf(a){H.call(this,a,1)}
v(rf,H);function sf(a){H.call(this,a)}
v(sf,H);var tf;tf=new function(a,b,c,d){this.h=a;this.fieldName=b;this.isRepeated=d;this.i=xc}(406606992,{Pb:0},sf,0);function uf(){sf.apply(this,arguments)}
v(uf,sf);var vf,wf,xf,yf=B.window,zf=(null===(vf=null===yf||void 0===yf?void 0:yf.yt)||void 0===vf?void 0:vf.config_)||(null===(wf=null===yf||void 0===yf?void 0:yf.ytcfg)||void 0===wf?void 0:wf.data_)||{},Af=(null===(xf=null===yf||void 0===yf?void 0:yf.ytcfg)||void 0===xf?void 0:xf.obfuscatedData_)||[];function Bf(){rf.apply(this,arguments)}
v(Bf,rf);var Cf=new Bf(Af),Df=zf.EXPERIMENT_FLAGS;if(!Df||!Df.jspb_i18n_extension){var Ef=new uf;tf.i(Cf,Ef)}D("yt.config_",zf);D("yt.configJspb_",Af);function Ff(){var a=arguments;1<a.length?zf[a[0]]=a[1]:1===a.length&&Object.assign(zf,a[0])}
function L(a,b){return a in zf?zf[a]:b}
function Gf(){return L("LATEST_ECATCHER_SERVICE_TRACKING_PARAMS",void 0)}
;var Hf=[];function If(a){Hf.forEach(function(b){return b(a)})}
function Jf(a){return a&&window.yterr?function(){try{return a.apply(this,arguments)}catch(b){Kf(b)}}:a}
function Kf(a,b,c,d){var e=C("yt.logging.errors.log");e?e(a,"ERROR",b,c,d):(e=L("ERRORS",[]),e.push([a,"ERROR",b,c,d]),Ff("ERRORS",e));If(a)}
function Lf(a,b,c,d){var e=C("yt.logging.errors.log");e?e(a,"WARNING",b,c,d):(e=L("ERRORS",[]),e.push([a,"WARNING",b,c,d]),Ff("ERRORS",e))}
;var Mf=0;D("ytDomDomGetNextId",C("ytDomDomGetNextId")||function(){return++Mf});var Nf={stopImmediatePropagation:1,stopPropagation:1,preventMouseEvent:1,preventManipulation:1,preventDefault:1,layerX:1,layerY:1,screenX:1,screenY:1,scale:1,rotation:1,webkitMovementX:1,webkitMovementY:1};
function Of(a){this.type="";this.state=this.source=this.data=this.currentTarget=this.relatedTarget=this.target=null;this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.ctrlKey=this.altKey=!1;this.rotation=this.clientY=this.clientX=0;this.scale=1;this.changedTouches=this.touches=null;try{if(a=a||window.event){this.event=a;for(var b in a)b in Nf||(this[b]=a[b]);this.scale=a.scale;this.rotation=a.rotation;var c=a.target||a.srcElement;c&&3==c.nodeType&&(c=c.parentNode);this.target=c;var d=a.relatedTarget;
if(d)try{d=d.nodeName?d:null}catch(e){d=null}else"mouseover"==this.type?d=a.fromElement:"mouseout"==this.type&&(d=a.toElement);this.relatedTarget=d;this.clientX=void 0!=a.clientX?a.clientX:a.pageX;this.clientY=void 0!=a.clientY?a.clientY:a.pageY;this.keyCode=a.keyCode?a.keyCode:a.which;this.charCode=a.charCode||("keypress"==this.type?this.keyCode:0);this.altKey=a.altKey;this.ctrlKey=a.ctrlKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey}}catch(e){}}
Of.prototype.preventDefault=function(){this.event&&(this.event.returnValue=!1,this.event.preventDefault&&this.event.preventDefault())};
Of.prototype.stopPropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopPropagation&&this.event.stopPropagation())};
Of.prototype.stopImmediatePropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopImmediatePropagation&&this.event.stopImmediatePropagation())};var db=B.ytEventsEventsListeners||{};D("ytEventsEventsListeners",db);var Pf=B.ytEventsEventsCounter||{count:0};D("ytEventsEventsCounter",Pf);
function Qf(a,b,c,d){d=void 0===d?{}:d;a.addEventListener&&("mouseenter"!=b||"onmouseenter"in document?"mouseleave"!=b||"onmouseenter"in document?"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"):b="mouseout":b="mouseover");return cb(function(e){var f="boolean"===typeof e[4]&&e[4]==!!d,g=La(e[4])&&La(d)&&eb(e[4],d);return!!e.length&&e[0]==a&&e[1]==b&&e[2]==c&&(f||g)})}
function Rf(a){a&&("string"==typeof a&&(a=[a]),F(a,function(b){if(b in db){var c=db[b],d=c[0],e=c[1],f=c[3];c=c[4];d.removeEventListener?Sf()||"boolean"===typeof c?d.removeEventListener(e,f,c):d.removeEventListener(e,f,!!c.capture):d.detachEvent&&d.detachEvent("on"+e,f);delete db[b]}}))}
var Sf=Va(function(){var a=!1;try{var b=Object.defineProperty({},"capture",{get:function(){a=!0}});
window.addEventListener("test",null,b)}catch(c){}return a});
function Tf(a,b,c){var d=void 0===d?{}:d;if(a&&(a.addEventListener||a.attachEvent)){var e=Qf(a,b,c,d);if(!e){e=++Pf.count+"";var f=!("mouseenter"!=b&&"mouseleave"!=b||!a.addEventListener||"onmouseenter"in document);var g=f?function(h){h=new Of(h);if(!Bc(h.relatedTarget,function(k){return k==a}))return h.currentTarget=a,h.type=b,c.call(a,h)}:function(h){h=new Of(h);
h.currentTarget=a;return c.call(a,h)};
g=Jf(g);a.addEventListener?("mouseenter"==b&&f?b="mouseover":"mouseleave"==b&&f?b="mouseout":"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"),Sf()||"boolean"===typeof d?a.addEventListener(b,g,d):a.addEventListener(b,g,!!d.capture)):a.attachEvent("on"+b,g);db[e]=[a,b,c,g,d]}}}
;function Uf(a,b){"function"===typeof a&&(a=Jf(a));return window.setTimeout(a,b)}
function Vf(a){"function"===typeof a&&(a=Jf(a));return window.setInterval(a,250)}
;var Wf=/^[\w.]*$/,Xf={q:!0,search_query:!0};function Yf(a,b){b=a.split(b);for(var c={},d=0,e=b.length;d<e;d++){var f=b[d].split("=");if(1==f.length&&f[0]||2==f.length)try{var g=Zf(f[0]||""),h=Zf(f[1]||"");g in c?Array.isArray(c[g])?ab(c[g],h):c[g]=[c[g],h]:c[g]=h}catch(p){var k=p,l=f[0],m=String(Yf);k.args=[{key:l,value:f[1],query:a,method:$f==m?"unchanged":m}];Xf.hasOwnProperty(l)||Lf(k)}}return c}
var $f=String(Yf);function ag(a){var b=[];bb(a,function(c,d){var e=encodeURIComponent(String(d)),f;Array.isArray(c)?f=c:f=[c];F(f,function(g){""==g?b.push(e):b.push(e+"="+encodeURIComponent(String(g)))})});
return b.join("&")}
function bg(a){"?"==a.charAt(0)&&(a=a.substr(1));return Yf(a,"&")}
function cg(a,b,c){var d=a.split("#",2);a=d[0];d=1<d.length?"#"+d[1]:"";var e=a.split("?",2);a=e[0];e=bg(e[1]||"");for(var f in b)!c&&null!==e&&f in e||(e[f]=b[f]);b=a;a=Db(e);a?(c=b.indexOf("#"),0>c&&(c=b.length),f=b.indexOf("?"),0>f||f>c?(f=c,e=""):e=b.substring(f+1,c),b=[b.substr(0,f),e,b.substr(c)],c=b[1],b[1]=a?c?c+"&"+a:a:c,a=b[0]+(b[1]?"?"+b[1]:"")+b[2]):a=b;return a+d}
function dg(a){if(!b)var b=window.location.href;var c=a.match(yb)[1]||null,d=Ab(a);c&&d?(a=a.match(yb),b=b.match(yb),a=a[3]==b[3]&&a[1]==b[1]&&a[4]==b[4]):a=d?Ab(b)==d&&(Number(b.match(yb)[4]||null)||null)==(Number(a.match(yb)[4]||null)||null):!0;return a}
function Zf(a){return a&&a.match(Wf)?a:decodeURIComponent(a.replace(/\+/g," "))}
;function N(a){a=eg(a);return"string"===typeof a&&"false"===a?!1:!!a}
function fg(a,b){a=eg(a);return void 0===a&&void 0!==b?b:Number(a||0)}
function eg(a){var b=L("EXPERIMENTS_FORCED_FLAGS",{});return void 0!==b[a]?b[a]:L("EXPERIMENT_FLAGS",{})[a]}
function gg(){var a=[],b=L("EXPERIMENTS_FORCED_FLAGS",{});for(c in b)a.push({key:c,value:String(b[c])});var c=L("EXPERIMENT_FLAGS",{});for(var d in c)d.startsWith("force_")&&void 0===b[d]&&a.push({key:d,value:String(c[d])});return a}
;var hg={Jb:"WEB_DISPLAY_MODE_UNKNOWN",Fb:"WEB_DISPLAY_MODE_BROWSER",Hb:"WEB_DISPLAY_MODE_MINIMAL_UI",Ib:"WEB_DISPLAY_MODE_STANDALONE",Gb:"WEB_DISPLAY_MODE_FULLSCREEN"};var ig={appSettingsCaptured:!0,visualElementAttached:!0,visualElementGestured:!0,visualElementHidden:!0,visualElementShown:!0,flowEvent:!0,visualElementStateChanged:!0,playbackAssociated:!0,youThere:!0,accountStateChangeSignedIn:!0,accountStateChangeSignedOut:!0},jg={latencyActionBaselined:!0,latencyActionInfo:!0,latencyActionTicked:!0,bedrockRepetitiveActionTimed:!0,adsClientStateChange:!0,streamzIncremented:!0,mdxDialAdditionalDataUpdateEvent:!0,tvhtml5WatchKeyEvent:!0,tvhtml5VideoSeek:!0,tokenRefreshEvent:!0,
adNotify:!0,adNotifyFilled:!0,tvhtml5LaunchUrlComponentChanged:!0,bedrockResourceConsumptionSnapshot:!0,deviceStartupMetrics:!0,mdxSignIn:!0,tvhtml5KeyboardLogging:!0,tvhtml5StartupSoundEvent:!0,tvhtml5LiveChatStatus:!0,tvhtml5DeviceStorageStatus:!0,tvhtml5LocalStorage:!0,directSignInEvent:!0,finalPayload:!0,tvhtml5SearchCompleted:!0,tvhtml5KeyboardPerformance:!0,adNotifyFailure:!0,latencyActionSpan:!0,tvhtml5AccountDialogOpened:!0,tvhtml5ApiTest:!0};function kg(){}
function lg(a,b){return mg(a,0,b)}
kg.prototype.L=function(a,b){return mg(a,1,b)};
function ng(a,b){mg(a,2,b)}
;function og(){kg.apply(this,arguments)}
v(og,kg);function pg(){og.h||(og.h=new og);return og.h}
function mg(a,b,c){void 0!==c&&Number.isNaN(Number(c))&&(c=void 0);var d=C("yt.scheduler.instance.addJob");return d?d(a,b,c):void 0===c?(a(),NaN):Uf(a,c||0)}
og.prototype.W=function(a){if(void 0===a||!Number.isNaN(Number(a))){var b=C("yt.scheduler.instance.cancelJob");b?b(a):window.clearTimeout(a)}};
og.prototype.start=function(){var a=C("yt.scheduler.instance.start");a&&a()};var qg=pg();function rg(a){var b=sg;a=void 0===a?C("yt.ads.biscotti.lastId_")||"":a;var c=Object,d=c.assign,e={};e.dt=Ic;e.flash="0";a:{try{var f=b.h.top.location.href}catch(wa){f=2;break a}f=f?f===b.i.location.href?0:1:2}e=(e.frm=f,e);try{e.u_tz=-(new Date).getTimezoneOffset();var g=void 0===g?yc:g;try{var h=g.history.length}catch(wa){h=0}e.u_his=h;var k;e.u_h=null==(k=yc.screen)?void 0:k.height;var l;e.u_w=null==(l=yc.screen)?void 0:l.width;var m;e.u_ah=null==(m=yc.screen)?void 0:m.availHeight;var p;e.u_aw=
null==(p=yc.screen)?void 0:p.availWidth;var u;e.u_cd=null==(u=yc.screen)?void 0:u.colorDepth}catch(wa){}h=b.h;try{var q=h.screenX;var x=h.screenY}catch(wa){}try{var y=h.outerWidth;var A=h.outerHeight}catch(wa){}try{var M=h.innerWidth;var O=h.innerHeight}catch(wa){}try{var P=h.screenLeft;var Mb=h.screenTop}catch(wa){}try{M=h.innerWidth,O=h.innerHeight}catch(wa){}try{var Sd=h.screen.availWidth;var Hj=h.screen.availTop}catch(wa){}q=[P,Mb,q,x,Sd,Hj,y,A,M,O];x=b.h.top;try{var ea=(x||window).document,U=
"CSS1Compat"==ea.compatMode?ea.documentElement:ea.body;var la=(new zc(U.clientWidth,U.clientHeight)).round()}catch(wa){la=new zc(-12245933,-12245933)}ea=la;la={};U=new Dd;B.SVGElement&&B.document.createElementNS&&U.set(0);x=Gc();x["allow-top-navigation-by-user-activation"]&&U.set(1);x["allow-popups-to-escape-sandbox"]&&U.set(2);B.crypto&&B.crypto.subtle&&U.set(3);B.TextDecoder&&B.TextEncoder&&U.set(4);U=Ed(U);la.bc=U;la.bih=ea.height;la.biw=ea.width;la.brdim=q.join();b=b.i;ea="Ba";Fd.Ba&&Fd.hasOwnProperty(ea)?
ea=Fd.Ba:(U=new Fd,Fd.Ba=U,Fd.hasOwnProperty(ea),ea=U);b=(la.vis=ea.A(Jc.flag,Jc.defaultValue)&&b.prerendering?3:{visible:1,hidden:2,prerender:3,preview:4,unloaded:5}[b.visibilityState||b.webkitVisibilityState||b.mozVisibilityState||""]||0,la.wgl=!!yc.WebGLRenderingContext,la);c=d.call(c,e,b);c.ca_type="image";a&&(c.bid=a);return c}
var sg=new function(){var a=window.document;this.h=window;this.i=a};
D("yt.ads_.signals_.getAdSignalsString",function(a){return ag(rg(a))});Date.now();var tg="XMLHttpRequest"in B?function(){return new XMLHttpRequest}:null;
function ug(){if(!tg)return null;var a=tg();return"open"in a?a:null}
;var vg={Authorization:"AUTHORIZATION","X-Goog-Visitor-Id":"SANDBOXED_VISITOR_ID","X-Youtube-Domain-Admin-State":"DOMAIN_ADMIN_STATE","X-Youtube-Chrome-Connected":"CHROME_CONNECTED_HEADER","X-YouTube-Client-Name":"INNERTUBE_CONTEXT_CLIENT_NAME","X-YouTube-Client-Version":"INNERTUBE_CONTEXT_CLIENT_VERSION","X-YouTube-Delegation-Context":"INNERTUBE_CONTEXT_SERIALIZED_DELEGATION_CONTEXT","X-YouTube-Device":"DEVICE","X-Youtube-Identity-Token":"ID_TOKEN","X-YouTube-Page-CL":"PAGE_CL","X-YouTube-Page-Label":"PAGE_BUILD_LABEL",
"X-YouTube-Variants-Checksum":"VARIANTS_CHECKSUM"},wg="app debugcss debugjs expflag force_ad_params force_ad_encrypted force_viral_ad_response_params forced_experiments innertube_snapshots innertube_goldens internalcountrycode internalipoverride absolute_experiments conditional_experiments sbb sr_bns_address".split(" ").concat(ha("client_dev_mss_url client_dev_regex_map client_dev_root_url expflag jsfeat jsmode client_rollout_override".split(" "))),xg=!1;
function yg(a,b){b=void 0===b?{}:b;var c=dg(a),d=N("web_ajax_ignore_global_headers_if_set"),e;for(e in vg){var f=L(vg[e]);!f||!c&&Ab(a)||d&&void 0!==b[e]||(b[e]=f)}if(c||!Ab(a))b["X-YouTube-Utc-Offset"]=String(-(new Date).getTimezoneOffset());if(c||!Ab(a)){try{var g=(new Intl.DateTimeFormat).resolvedOptions().timeZone}catch(h){}g&&(b["X-YouTube-Time-Zone"]=g)}if(c||!Ab(a))b["X-YouTube-Ad-Signals"]=ag(rg(void 0));return b}
function zg(a){var b=window.location.search,c=Ab(a);N("debug_handle_relative_url_for_query_forward_killswitch")||c||!dg(a)||(c=document.location.hostname);var d=zb(a.match(yb)[5]||null);d=(c=c&&(c.endsWith("youtube.com")||c.endsWith("youtube-nocookie.com")))&&d&&d.startsWith("/api/");if(!c||d)return a;var e=bg(b),f={};F(wg,function(g){e[g]&&(f[g]=e[g])});
return cg(a,f||{},!1)}
function Ag(a,b){var c=b.format||"JSON";a=Bg(a,b);var d=Cg(a,b),e=!1,f=Dg(a,function(k){if(!e){e=!0;h&&window.clearTimeout(h);a:switch(k&&"status"in k?k.status:-1){case 200:case 201:case 202:case 203:case 204:case 205:case 206:case 304:var l=!0;break a;default:l=!1}var m=null,p=400<=k.status&&500>k.status,u=500<=k.status&&600>k.status;if(l||p||u)m=Eg(a,c,k,b.convertToSafeHtml);if(l)a:if(k&&204==k.status)l=!0;else{switch(c){case "XML":l=0==parseInt(m&&m.return_code,10);break a;case "RAW":l=!0;break a}l=
!!m}m=m||{};p=b.context||B;l?b.onSuccess&&b.onSuccess.call(p,k,m):b.onError&&b.onError.call(p,k,m);b.onFinish&&b.onFinish.call(p,k,m)}},b.method,d,b.headers,b.responseType,b.withCredentials);
if(b.onTimeout&&0<b.timeout){var g=b.onTimeout;var h=Uf(function(){e||(e=!0,f.abort(),window.clearTimeout(h),g.call(b.context||B,f))},b.timeout)}}
function Bg(a,b){b.includeDomain&&(a=document.location.protocol+"//"+document.location.hostname+(document.location.port?":"+document.location.port:"")+a);var c=L("XSRF_FIELD_NAME",void 0);if(b=b.urlParams)b[c]&&delete b[c],a=cg(a,b||{},!0);return a}
function Cg(a,b){var c=L("XSRF_FIELD_NAME",void 0),d=L("XSRF_TOKEN",void 0),e=b.postBody||"",f=b.postParams,g=L("XSRF_FIELD_NAME",void 0),h;b.headers&&(h=b.headers["Content-Type"]);b.excludeXsrf||Ab(a)&&!b.withCredentials&&Ab(a)!=document.location.hostname||"POST"!=b.method||h&&"application/x-www-form-urlencoded"!=h||b.postParams&&b.postParams[g]||(f||(f={}),f[c]=d);f&&"string"===typeof e&&(e=bg(e),hb(e,f),e=b.postBodyFormat&&"JSON"==b.postBodyFormat?JSON.stringify(e):Db(e));if(!(a=e)&&(a=f)){a:{for(var k in f){f=
!1;break a}f=!0}a=!f}!xg&&a&&"POST"!=b.method&&(xg=!0,Kf(Error("AJAX request with postData should use POST")));return e}
function Eg(a,b,c,d){var e=null;switch(b){case "JSON":try{var f=c.responseText}catch(g){throw d=Error("Error reading responseText"),d.params=a,Lf(d),g;}a=c.getResponseHeader("Content-Type")||"";f&&0<=a.indexOf("json")&&(")]}'\n"===f.substring(0,5)&&(f=f.substring(5)),e=JSON.parse(f));break;case "XML":if(a=(a=c.responseXML)?Fg(a):null)e={},F(a.getElementsByTagName("*"),function(g){e[g.tagName]=Gg(g)})}d&&Hg(e);
return e}
function Hg(a){if(La(a))for(var b in a){var c;(c="html_content"==b)||(c=b.length-5,c=0<=c&&b.indexOf("_html",c)==c);if(c){c=b;kb("HTML that is escaped and sanitized server-side and passed through yt.net.ajax");var d=a[b];if(void 0===ib){var e=null;var f=B.trustedTypes;if(f&&f.createPolicy){try{e=f.createPolicy("goog#html",{createHTML:Sa,createScript:Sa,createScriptURL:Sa})}catch(g){B.console&&B.console.error(g.message)}ib=e}else ib=e}d=(e=ib)?e.createHTML(d):d;a[c]=new xb(d)}else Hg(a[b])}}
function Fg(a){return a?(a=("responseXML"in a?a.responseXML:a).getElementsByTagName("root"))&&0<a.length?a[0]:null:null}
function Gg(a){var b="";F(a.childNodes,function(c){b+=c.nodeValue});
return b}
function Dg(a,b,c,d,e,f,g){function h(){4==(k&&"readyState"in k?k.readyState:0)&&b&&Jf(b)(k)}
c=void 0===c?"GET":c;d=void 0===d?"":d;var k=ug();if(!k)return null;"onloadend"in k?k.addEventListener("loadend",h,!1):k.onreadystatechange=h;N("debug_forward_web_query_parameters")&&(a=zg(a));k.open(c,a,!0);f&&(k.responseType=f);g&&(k.withCredentials=!0);c="POST"==c&&(void 0===window.FormData||!(d instanceof FormData));if(e=yg(a,e))for(var l in e)k.setRequestHeader(l,e[l]),"content-type"==l.toLowerCase()&&(c=!1);c&&k.setRequestHeader("Content-Type","application/x-www-form-urlencoded");k.send(d);
return k}
;var Ig=B.ytPubsubPubsubInstance||new K,Jg=B.ytPubsubPubsubSubscribedKeys||{},Kg=B.ytPubsubPubsubTopicToKeys||{},Lg=B.ytPubsubPubsubIsSynchronous||{};K.prototype.subscribe=K.prototype.subscribe;K.prototype.unsubscribeByKey=K.prototype.ja;K.prototype.publish=K.prototype.ca;K.prototype.clear=K.prototype.clear;D("ytPubsubPubsubInstance",Ig);D("ytPubsubPubsubTopicToKeys",Kg);D("ytPubsubPubsubIsSynchronous",Lg);D("ytPubsubPubsubSubscribedKeys",Jg);var Mg=window,Q=Mg.ytcsi&&Mg.ytcsi.now?Mg.ytcsi.now:Mg.performance&&Mg.performance.timing&&Mg.performance.now&&Mg.performance.timing.navigationStart?function(){return Mg.performance.timing.navigationStart+Mg.performance.now()}:function(){return(new Date).getTime()};var Ng=fg("initial_gel_batch_timeout",2E3),Og=Math.pow(2,16)-1,Pg=void 0;function Qg(){this.j=this.h=this.i=0}
var Rg=new Qg,Sg=new Qg,Tg=!0,Ug=B.ytLoggingTransportGELQueue_||new Map;D("ytLoggingTransportGELQueue_",Ug);var Vg=B.ytLoggingTransportGELProtoQueue_||new Map;D("ytLoggingTransportGELProtoQueue_",Vg);var Wg=B.ytLoggingTransportTokensToCttTargetIds_||{};D("ytLoggingTransportTokensToCttTargetIds_",Wg);var Xg=B.ytLoggingTransportTokensToJspbCttTargetIds_||{};D("ytLoggingTransportTokensToJspbCttTargetIds_",Xg);
function Yg(a,b){if("log_event"===a.endpoint){var c=Zg(a),d=Ug.get(c)||[];Ug.set(c,d);d.push(a.payload);var e=void 0===e?!1:e;b&&(Pg=new b);a=fg("tvhtml5_logging_max_batch")||fg("web_logging_max_batch")||100;b=Q();var f=e?Sg.j:Rg.j;d.length>=a?$g({writeThenSend:!0},N("flush_only_full_queue")?c:void 0,e):10<=b-f&&(ah(e),e?Sg.j=b:Rg.j=b)}}
function bh(a,b){if("log_event"===a.endpoint){var c=Zg(a),d=new Map;d.set(c,[a.payload]);b&&(Pg=new b);return new qe(function(e){Pg&&Pg.isReady()?ch(d,e,{bypassNetworkless:!0},!0):e()})}}
function Zg(a){var b="";if(a.xa)b="visitorOnlyApprovedKey";else if(a.da){b=a.da;var c={};b.videoId?c.videoId=b.videoId:b.playlistId&&(c.playlistId=b.playlistId);Wg[a.da.token]=c;b=a.da.token}return b}
function $g(a,b,c){a=void 0===a?{}:a;c=void 0===c?!1:c;new qe(function(d){c?(window.clearTimeout(Sg.i),window.clearTimeout(Sg.h),Sg.h=0):(window.clearTimeout(Rg.i),window.clearTimeout(Rg.h),Rg.h=0);if(Pg&&Pg.isReady())if(void 0!==b)if(c){var e=new Map,f=Vg.get(b)||[];e.set(b,f);dh(e,d,a);Vg.delete(b)}else e=new Map,f=Ug.get(b)||[],e.set(b,f),ch(e,d,a),Ug.delete(b);else c?(dh(Vg,d,a),Vg.clear()):(ch(Ug,d,a),Ug.clear());else ah(c),d()})}
function ah(a){a=void 0===a?!1:a;if(N("web_gel_timeout_cap")&&(!a&&!Rg.h||a&&!Sg.h)){var b=Uf(function(){$g({writeThenSend:!0},void 0,a)},6E4);
a?Sg.h=b:Rg.h=b}window.clearTimeout(a?Sg.i:Rg.i);b=L("LOGGING_BATCH_TIMEOUT",fg("web_gel_debounce_ms",1E4));N("shorten_initial_gel_batch_timeout")&&Tg&&(b=Ng);b=Uf(function(){$g({writeThenSend:!0},void 0,a)},b);
a?Sg.i=b:Rg.i=b}
function ch(a,b,c,d){var e=Pg;c=void 0===c?{}:c;var f=Math.round(Q()),g=a.size;a=t(a);for(var h=a.next();!h.done;h=a.next()){var k=t(h.value);h=k.next().value;var l=k=k.next().value;k=fb({context:eh(e.config_||fh())});k.events=l;(l=Wg[h])&&gh(k,h,l);delete Wg[h];h="visitorOnlyApprovedKey"===h;hh(k,f,h);ih(c);jh(e,"log_event",k,kh(c,h,function(){g--;g||b()},function(){g--;
g||b()},d));
Tg=!1}}
function dh(a,b,c){var d=Pg;c=void 0===c?{}:c;var e=Math.round(Q()),f=a.size;a=t(a);for(var g=a.next();!g.done;g=a.next()){var h=t(g.value);g=h.next().value;var k=h=h.next().value;h=new pf;var l=lh(d.config_||fh());tc(h,1,l);for(l=0;l<k.length;l++)uc(h,3,mf,k[l]);(k=Xg[g])&&mh(h,g,k);delete Xg[g];g="visitorOnlyApprovedKey"===g;nh(h,e,g);ih(c);a:{gc=!0;try{var m=JSON.stringify(h.toJSON(),vc);break a}finally{gc=!1}m=void 0}h=m;g=kh(c,g,function(){f--;f||b()},function(){f--;
f||b()},void 0);
g.headers={"Content-Type":"application/json+protobuf"};g.postBodyFormat="JSPB";g.postBody=h;jh(d,"log_event","",g);Tg=!1}}
function ih(a){N("always_send_and_write")&&(a.writeThenSend=!1)}
function kh(a,b,c,d,e){return{retry:!0,onSuccess:c,onError:d,Ta:a,xa:b,Nb:!!e,headers:{},postBodyFormat:"",postBody:""}}
function hh(a,b,c){a.requestTimeMs=String(b);N("unsplit_gel_payloads_in_logs")&&(a.unsplitGelPayloadsInLogs=!0);!c&&(b=L("EVENT_ID",void 0))&&(c=oh(),a.serializedClientEventId={serializedEventId:b,clientCounter:String(c)})}
function nh(a,b,c){I(a,2,b);if(!c&&(b=L("EVENT_ID",void 0))){c=oh();var d=new nf;I(d,1,b);I(d,2,c);tc(a,5,d)}}
function oh(){var a=L("BATCH_CLIENT_COUNTER",void 0)||0;a||(a=Math.floor(Math.random()*Og/2));a++;a>Og&&(a=1);Ff("BATCH_CLIENT_COUNTER",a);return a}
function gh(a,b,c){if(c.videoId)var d="VIDEO";else if(c.playlistId)d="PLAYLIST";else return;a.credentialTransferTokenTargetId=c;a.context=a.context||{};a.context.user=a.context.user||{};a.context.user.credentialTransferTokens=[{token:b,scope:d}]}
function mh(a,b,c){if(oc(c,1===qc(c,of)?1:-1))var d=1;else if(c.getPlaylistId())d=2;else return;tc(a,4,c);a=rc(a,kf,1)||new kf;c=rc(a,hf,3)||new hf;var e=new gf;e.setToken(b);I(e,1,d);uc(c,12,gf,e);tc(a,3,c)}
;var ph=B.ytLoggingGelSequenceIdObj_||{};D("ytLoggingGelSequenceIdObj_",ph);function qh(){if(!B.matchMedia)return"WEB_DISPLAY_MODE_UNKNOWN";try{return B.matchMedia("(display-mode: standalone)").matches?"WEB_DISPLAY_MODE_STANDALONE":B.matchMedia("(display-mode: minimal-ui)").matches?"WEB_DISPLAY_MODE_MINIMAL_UI":B.matchMedia("(display-mode: fullscreen)").matches?"WEB_DISPLAY_MODE_FULLSCREEN":B.matchMedia("(display-mode: browser)").matches?"WEB_DISPLAY_MODE_BROWSER":"WEB_DISPLAY_MODE_UNKNOWN"}catch(a){return"WEB_DISPLAY_MODE_UNKNOWN"}}
function rh(){var a=qh();a=Object.keys(hg).indexOf(a);return-1===a?null:a}
;D("ytglobal.prefsUserPrefsPrefs_",C("ytglobal.prefsUserPrefsPrefs_")||{});var sh={bluetooth:"CONN_DISCO",cellular:"CONN_CELLULAR_UNKNOWN",ethernet:"CONN_WIFI",none:"CONN_NONE",wifi:"CONN_WIFI",wimax:"CONN_CELLULAR_4G",other:"CONN_UNKNOWN",unknown:"CONN_UNKNOWN","slow-2g":"CONN_CELLULAR_2G","2g":"CONN_CELLULAR_2G","3g":"CONN_CELLULAR_3G","4g":"CONN_CELLULAR_4G"},th={CONN_DEFAULT:0,CONN_UNKNOWN:1,CONN_NONE:2,CONN_WIFI:3,CONN_CELLULAR_2G:4,CONN_CELLULAR_3G:5,CONN_CELLULAR_4G:6,CONN_CELLULAR_UNKNOWN:7,CONN_DISCO:8,CONN_CELLULAR_5G:9,CONN_WIFI_METERED:10,CONN_CELLULAR_5G_SA:11,
CONN_CELLULAR_5G_NSA:12,CONN_INVALID:31},uh={EFFECTIVE_CONNECTION_TYPE_UNKNOWN:0,EFFECTIVE_CONNECTION_TYPE_OFFLINE:1,EFFECTIVE_CONNECTION_TYPE_SLOW_2G:2,EFFECTIVE_CONNECTION_TYPE_2G:3,EFFECTIVE_CONNECTION_TYPE_3G:4,EFFECTIVE_CONNECTION_TYPE_4G:5},vh={"slow-2g":"EFFECTIVE_CONNECTION_TYPE_SLOW_2G","2g":"EFFECTIVE_CONNECTION_TYPE_2G","3g":"EFFECTIVE_CONNECTION_TYPE_3G","4g":"EFFECTIVE_CONNECTION_TYPE_4G"};function wh(){var a=B.navigator;return a?a.connection:void 0}
;function xh(){return"INNERTUBE_API_KEY"in zf&&"INNERTUBE_API_VERSION"in zf}
function fh(){return{innertubeApiKey:L("INNERTUBE_API_KEY",void 0),innertubeApiVersion:L("INNERTUBE_API_VERSION",void 0),za:L("INNERTUBE_CONTEXT_CLIENT_CONFIG_INFO"),Aa:L("INNERTUBE_CONTEXT_CLIENT_NAME","WEB"),lb:L("INNERTUBE_CONTEXT_CLIENT_NAME",1),innertubeContextClientVersion:L("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0),Qa:L("INNERTUBE_CONTEXT_HL",void 0),Pa:L("INNERTUBE_CONTEXT_GL",void 0),mb:L("INNERTUBE_HOST_OVERRIDE",void 0)||"",ob:!!L("INNERTUBE_USE_THIRD_PARTY_AUTH",!1),nb:!!L("INNERTUBE_OMIT_API_KEY_WHEN_AUTH_HEADER_IS_PRESENT",
!1),appInstallData:L("SERIALIZED_CLIENT_CONFIG_DATA",void 0)}}
function eh(a){var b={client:{hl:a.Qa,gl:a.Pa,clientName:a.Aa,clientVersion:a.innertubeContextClientVersion,configInfo:a.za}};navigator.userAgent&&(b.client.userAgent=String(navigator.userAgent));var c=B.devicePixelRatio;c&&1!=c&&(b.client.screenDensityFloat=String(c));c=L("EXPERIMENTS_TOKEN","");""!==c&&(b.client.experimentsToken=c);c=gg();0<c.length&&(b.request={internalExperimentFlags:c});yh(a,void 0,b);zh(a,void 0,b);Ah(void 0,b);Bh(a,void 0,b);Ch(void 0,b);L("DELEGATED_SESSION_ID")&&!N("pageid_as_header_web")&&
(b.user={onBehalfOfUser:L("DELEGATED_SESSION_ID")});a=Object;c=a.assign;for(var d=b.client,e={},f=t(Object.entries(bg(L("DEVICE","")))),g=f.next();!g.done;g=f.next()){var h=t(g.value);g=h.next().value;h=h.next().value;"cbrand"===g?e.deviceMake=h:"cmodel"===g?e.deviceModel=h:"cbr"===g?e.browserName=h:"cbrver"===g?e.browserVersion=h:"cos"===g?e.osName=h:"cosver"===g?e.osVersion=h:"cplatform"===g&&(e.platform=h)}b.client=c.call(a,d,e);return b}
function lh(a){var b=new kf,c=new cf;I(c,1,a.Qa);I(c,2,a.Pa);I(c,16,a.lb);I(c,17,a.innertubeContextClientVersion);if(a.za){var d=a.za,e=new $e;d.coldConfigData&&I(e,1,d.coldConfigData);d.appInstallData&&I(e,6,d.appInstallData);d.coldHashData&&I(e,3,d.coldHashData);d.hotHashData&&I(e,5,d.hotHashData);tc(c,62,e)}(d=B.devicePixelRatio)&&1!=d&&I(c,65,d);d=L("EXPERIMENTS_TOKEN","");""!==d&&I(c,54,d);d=gg();if(0<d.length){e=new ef;for(var f=0;f<d.length;f++){var g=new Ye;I(g,1,d[f].key);g.setValue(d[f].value);
uc(e,15,Ye,g)}tc(b,5,e)}yh(a,c);zh(a,c);Ah(c);Bh(a,c);Ch(c);L("DELEGATED_SESSION_ID")&&!N("pageid_as_header_web")&&(a=new hf,I(a,3,L("DELEGATED_SESSION_ID")));a=t(Object.entries(bg(L("DEVICE",""))));for(d=a.next();!d.done;d=a.next())e=t(d.value),d=e.next().value,e=e.next().value,"cbrand"===d?I(c,12,e):"cmodel"===d?I(c,13,e):"cbr"===d?I(c,87,e):"cbrver"===d?I(c,88,e):"cos"===d?I(c,18,e):"cosver"===d?I(c,19,e):"cplatform"===d&&I(c,42,e);tc(b,1,c);return b}
function yh(a,b,c){a=a.Aa;if("WEB"===a||"MWEB"===a||1===a||2===a)if(b){c=rc(b,af,96)||new af;var d=rh();null!==d&&I(c,3,d);tc(b,96,c)}else c&&(c.client.mainAppWebInfo=null!=(d=c.client.mainAppWebInfo)?d:{},c.client.mainAppWebInfo.webDisplayMode=qh())}
function zh(a,b,c){a=a.Aa;if(("WEB_REMIX"===a||76===a)&&!N("music_web_display_mode_killswitch"))if(b){var d;c=null!=(d=rc(b,bf,70))?d:new bf;d=rh();null!==d&&I(c,10,d);tc(b,70,c)}else if(c){var e;c.client.Sa=null!=(e=c.client.Sa)?e:{};c.client.Sa.webDisplayMode=qh()}}
function Ah(a,b){var c;if(N("web_log_memory_total_kbytes")&&(null==(c=B.navigator)?0:c.deviceMemory)){var d;c=null==(d=B.navigator)?void 0:d.deviceMemory;a?I(a,95,1E6*c):b&&(b.client.memoryTotalKbytes=""+1E6*c)}}
function Bh(a,b,c){if(a.appInstallData)if(b){var d;c=null!=(d=rc(b,$e,62))?d:new $e;I(c,6,a.appInstallData);tc(b,62,c)}else c&&(c.client.configInfo=c.client.configInfo||{},c.client.configInfo.appInstallData=a.appInstallData)}
function Ch(a,b){a:{var c=wh();if(c){var d=sh[c.type||"unknown"]||"CONN_UNKNOWN";c=sh[c.effectiveType||"unknown"]||"CONN_UNKNOWN";"CONN_CELLULAR_UNKNOWN"===d&&"CONN_UNKNOWN"!==c&&(d=c);if("CONN_UNKNOWN"!==d)break a;if("CONN_UNKNOWN"!==c){d=c;break a}}d=void 0}d&&(a?I(a,61,th[d]):b&&(b.client.connectionType=d));N("web_log_effective_connection_type")&&(d=wh(),d=null!==d&&void 0!==d&&d.effectiveType?vh.hasOwnProperty(d.effectiveType)?vh[d.effectiveType]:"EFFECTIVE_CONNECTION_TYPE_UNKNOWN":void 0,d&&
(a?I(a,94,uh[d]):b&&(b.client.effectiveConnectionType=d)))}
function Dh(a,b,c){c=void 0===c?{}:c;var d={"X-Goog-Visitor-Id":c.visitorData||L("VISITOR_DATA","")};if(b&&b.includes("www.youtube-nocookie.com"))return d;(b=c.Lb||L("AUTHORIZATION"))||(a?b="Bearer "+C("gapi.auth.getToken")().Kb:b=Uc([]));b&&(d.Authorization=b,d["X-Goog-AuthUser"]=L("SESSION_INDEX",0),N("pageid_as_header_web")&&(d["X-Goog-PageId"]=L("DELEGATED_SESSION_ID")));return d}
;function Eh(a){a=Object.assign({},a);delete a.Authorization;var b=Uc();if(b){var c=new Yd;c.update(L("INNERTUBE_API_KEY",void 0));c.update(b);a.hash=bc(c.digest(),3)}return a}
;function Fh(a){var b=new Re;(b=b.isAvailable()?a?new Xe(b,a):b:null)||(a=new Se(a||"UserDataSharedStore"),b=a.isAvailable()?a:null);this.h=(a=b)?new Ne(a):null;this.i=document.domain||window.location.hostname}
Fh.prototype.set=function(a,b,c,d){c=c||31104E3;this.remove(a);if(this.h)try{this.h.set(a,b,Date.now()+1E3*c);return}catch(f){}var e="";if(d)try{e=escape(oe(b))}catch(f){return}else e=escape(b);b=this.i;Rc.set(""+a,e,{Ca:c,path:"/",domain:void 0===b?"youtube.com":b,secure:!1})};
Fh.prototype.get=function(a,b){var c=void 0,d=!this.h;if(!d)try{c=this.h.get(a)}catch(e){d=!0}if(d&&(c=Rc.get(""+a,void 0))&&(c=unescape(c),b))try{c=JSON.parse(c)}catch(e){this.remove(a),c=void 0}return c};
Fh.prototype.remove=function(a){this.h&&this.h.remove(a);var b=this.i;Rc.remove(""+a,"/",void 0===b?"youtube.com":b)};var Gh;function Hh(){Gh||(Gh=new Fh("yt.innertube"));return Gh}
function Ih(a,b,c,d){if(d)return null;d=Hh().get("nextId",!0)||1;var e=Hh().get("requests",!0)||{};e[d]={method:a,request:b,authState:Eh(c),requestTime:Math.round(Q())};Hh().set("nextId",d+1,86400,!0);Hh().set("requests",e,86400,!0);return d}
function Jh(a){var b=Hh().get("requests",!0)||{};delete b[a];Hh().set("requests",b,86400,!0)}
function Kh(a){var b=Hh().get("requests",!0);if(b){for(var c in b){var d=b[c];if(!(6E4>Math.round(Q())-d.requestTime)){var e=d.authState,f=Eh(Dh(!1));eb(e,f)&&(e=d.request,"requestTimeMs"in e&&(e.requestTimeMs=Math.round(Q())),jh(a,d.method,e,{}));delete b[c]}}Hh().set("requests",b,86400,!0)}}
;var Lh=Xb||Yb;var Mh=function(){var a;return function(){a||(a=new Fh("ytidb"));return a}}();
function Nh(){var a;return null===(a=Mh())||void 0===a?void 0:a.get("LAST_RESULT_ENTRY_KEY",!0)}
;var Oh=[],Ph=!1;function Qh(a){Ph||(Oh.push({type:"ERROR",payload:a}),10<Oh.length&&Oh.shift())}
function Rh(a,b){Ph||(Oh.push({type:"EVENT",eventType:a,payload:b}),10<Oh.length&&Oh.shift())}
;function Sh(a){var b=Ea.apply(1,arguments);var c=Error.call(this,a);this.message=c.message;"stack"in c&&(this.stack=c.stack);this.args=[].concat(ha(b))}
v(Sh,Error);function Th(){try{return Uh(),!0}catch(a){return!1}}
function Uh(){if(void 0!==L("DATASYNC_ID",void 0))return L("DATASYNC_ID",void 0);throw new Sh("Datasync ID not set","unknown");}
;function Vh(a){if(0<=a.indexOf(":"))throw Error("Database name cannot contain ':'");}
function Wh(a){return a.substr(0,a.indexOf(":"))||a}
;var R={},Xh=(R.AUTH_INVALID="No user identifier specified.",R.EXPLICIT_ABORT="Transaction was explicitly aborted.",R.IDB_NOT_SUPPORTED="IndexedDB is not supported.",R.MISSING_INDEX="Index not created.",R.MISSING_OBJECT_STORES="Object stores not created.",R.DB_DELETED_BY_MISSING_OBJECT_STORES="Database is deleted because expected object stores were not created.",R.DB_REOPENED_BY_MISSING_OBJECT_STORES="Database is reopened because expected object stores were not created.",R.UNKNOWN_ABORT="Transaction was aborted for unknown reasons.",
R.QUOTA_EXCEEDED="The current transaction exceeded its quota limitations.",R.QUOTA_MAYBE_EXCEEDED="The current transaction may have failed because of exceeding quota limitations.",R.EXECUTE_TRANSACTION_ON_CLOSED_DB="Can't start a transaction on a closed database",R.INCOMPATIBLE_DB_VERSION="The binary is incompatible with the database version",R),S={},Yh=(S.AUTH_INVALID="ERROR",S.EXECUTE_TRANSACTION_ON_CLOSED_DB="WARNING",S.EXPLICIT_ABORT="IGNORED",S.IDB_NOT_SUPPORTED="ERROR",S.MISSING_INDEX="WARNING",
S.MISSING_OBJECT_STORES="ERROR",S.DB_DELETED_BY_MISSING_OBJECT_STORES="WARNING",S.DB_REOPENED_BY_MISSING_OBJECT_STORES="WARNING",S.QUOTA_EXCEEDED="WARNING",S.QUOTA_MAYBE_EXCEEDED="WARNING",S.UNKNOWN_ABORT="WARNING",S.INCOMPATIBLE_DB_VERSION="WARNING",S),T={},Zh=(T.AUTH_INVALID=!1,T.EXECUTE_TRANSACTION_ON_CLOSED_DB=!1,T.EXPLICIT_ABORT=!1,T.IDB_NOT_SUPPORTED=!1,T.MISSING_INDEX=!1,T.MISSING_OBJECT_STORES=!1,T.DB_DELETED_BY_MISSING_OBJECT_STORES=!1,T.DB_REOPENED_BY_MISSING_OBJECT_STORES=!1,T.QUOTA_EXCEEDED=
!1,T.QUOTA_MAYBE_EXCEEDED=!0,T.UNKNOWN_ABORT=!0,T.INCOMPATIBLE_DB_VERSION=!1,T);function V(a,b,c,d,e){b=void 0===b?{}:b;c=void 0===c?Xh[a]:c;d=void 0===d?Yh[a]:d;e=void 0===e?Zh[a]:e;Sh.call(this,c,Object.assign({name:"YtIdbKnownError",isSw:void 0===self.document,isIframe:self!==self.top,type:a},b));this.type=a;this.message=c;this.level=d;this.h=e;Object.setPrototypeOf(this,V.prototype)}
v(V,Sh);function $h(a,b){V.call(this,"MISSING_OBJECT_STORES",{expectedObjectStores:b,foundObjectStores:a},Xh.MISSING_OBJECT_STORES);Object.setPrototypeOf(this,$h.prototype)}
v($h,V);function ai(a,b){var c=Error.call(this);this.message=c.message;"stack"in c&&(this.stack=c.stack);this.index=a;this.objectStore=b;Object.setPrototypeOf(this,ai.prototype)}
v(ai,Error);var bi=["The database connection is closing","Can't start a transaction on a closed database","A mutation operation was attempted on a database that did not allow mutations"];
function ci(a,b,c,d){b=Wh(b);var e=a instanceof Error?a:Error("Unexpected error: "+a);if(e instanceof V)return e;a={objectStoreNames:c,dbName:b,dbVersion:d};if("QuotaExceededError"===e.name)return new V("QUOTA_EXCEEDED",a);if(Zb&&"UnknownError"===e.name)return new V("QUOTA_MAYBE_EXCEEDED",a);if(e instanceof ai)return new V("MISSING_INDEX",Object.assign(Object.assign({},a),{objectStore:e.objectStore,index:e.index}));if("InvalidStateError"===e.name&&bi.some(function(f){return e.message.includes(f)}))return new V("EXECUTE_TRANSACTION_ON_CLOSED_DB",
a);
if("AbortError"===e.name)return new V("UNKNOWN_ABORT",a,e.message);e.args=[Object.assign(Object.assign({},a),{name:"IdbError",Tb:e.name})];e.level="WARNING";return e}
function di(a,b,c){var d=Nh();return new V("IDB_NOT_SUPPORTED",{context:{caller:a,publicName:b,version:c,hasSucceededOnce:null===d||void 0===d?void 0:d.hasSucceededOnce}})}
;function ei(a){if(!a)throw Error();throw a;}
function fi(a){return a}
function gi(a){this.h=a}
function W(a){function b(e){if("PENDING"===d.state.status){d.state={status:"REJECTED",reason:e};e=t(d.onRejected);for(var f=e.next();!f.done;f=e.next())f=f.value,f()}}
function c(e){if("PENDING"===d.state.status){d.state={status:"FULFILLED",value:e};e=t(d.h);for(var f=e.next();!f.done;f=e.next())f=f.value,f()}}
var d=this;this.state={status:"PENDING"};this.h=[];this.onRejected=[];a=a.h;try{a(c,b)}catch(e){b(e)}}
W.all=function(a){return new W(new gi(function(b,c){var d=[],e=a.length;0===e&&b(d);for(var f={Z:0};f.Z<a.length;f={Z:f.Z},++f.Z)hi(W.resolve(a[f.Z]).then(function(g){return function(h){d[g.Z]=h;e--;0===e&&b(d)}}(f)),function(g){c(g)})}))};
W.resolve=function(a){return new W(new gi(function(b,c){a instanceof W?a.then(b,c):b(a)}))};
W.reject=function(a){return new W(new gi(function(b,c){c(a)}))};
W.prototype.then=function(a,b){var c=this,d=null!==a&&void 0!==a?a:fi,e=null!==b&&void 0!==b?b:ei;return new W(new gi(function(f,g){"PENDING"===c.state.status?(c.h.push(function(){ii(c,c,d,f,g)}),c.onRejected.push(function(){ji(c,c,e,f,g)})):"FULFILLED"===c.state.status?ii(c,c,d,f,g):"REJECTED"===c.state.status&&ji(c,c,e,f,g)}))};
function hi(a,b){a.then(void 0,b)}
function ii(a,b,c,d,e){try{if("FULFILLED"!==a.state.status)throw Error("calling handleResolve before the promise is fulfilled.");var f=c(a.state.value);f instanceof W?ki(a,b,f,d,e):d(f)}catch(g){e(g)}}
function ji(a,b,c,d,e){try{if("REJECTED"!==a.state.status)throw Error("calling handleReject before the promise is rejected.");var f=c(a.state.reason);f instanceof W?ki(a,b,f,d,e):d(f)}catch(g){e(g)}}
function ki(a,b,c,d,e){b===c?e(new TypeError("Circular promise chain detected.")):c.then(function(f){f instanceof W?ki(a,b,f,d,e):d(f)},function(f){e(f)})}
;function li(a,b,c){function d(){c(a.error);f()}
function e(){b(a.result);f()}
function f(){try{a.removeEventListener("success",e),a.removeEventListener("error",d)}catch(g){}}
a.addEventListener("success",e);a.addEventListener("error",d)}
function mi(a){return new Promise(function(b,c){li(a,b,c)})}
function X(a){return new W(new gi(function(b,c){li(a,b,c)}))}
;function ni(a,b){return new W(new gi(function(c,d){function e(){var f=a?b(a):null;f?f.then(function(g){a=g;e()},d):c()}
e()}))}
;function oi(a,b){this.h=a;this.options=b;this.transactionCount=0;this.j=Math.round(Q());this.i=!1}
n=oi.prototype;n.add=function(a,b,c){return pi(this,[a],{mode:"readwrite",G:!0},function(d){return d.objectStore(a).add(b,c)})};
n.clear=function(a){return pi(this,[a],{mode:"readwrite",G:!0},function(b){return b.objectStore(a).clear()})};
n.close=function(){var a;this.h.close();(null===(a=this.options)||void 0===a?0:a.closed)&&this.options.closed()};
n.count=function(a,b){return pi(this,[a],{mode:"readonly",G:!0},function(c){return c.objectStore(a).count(b)})};
function qi(a,b,c){a=a.h.createObjectStore(b,c);return new ri(a)}
n.delete=function(a,b){return pi(this,[a],{mode:"readwrite",G:!0},function(c){return c.objectStore(a).delete(b)})};
n.get=function(a,b){return pi(this,[a],{mode:"readonly",G:!0},function(c){return c.objectStore(a).get(b)})};
function si(a,b){return pi(a,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(c){c=c.objectStore("LogsRequestsStore");return X(c.h.put(b,void 0))})}
n.objectStoreNames=function(){return Array.from(this.h.objectStoreNames)};
function pi(a,b,c,d){var e,f,g,h,k,l,m,p,u,q,x,y;return z(function(A){switch(A.h){case 1:var M={mode:"readonly",G:!1,tag:"IDB_TRANSACTION_TAG_UNKNOWN"};"string"===typeof c?M.mode=c:Object.assign(M,c);e=M;a.transactionCount++;f=e.G?3:1;g=0;case 2:if(h){A.o(3);break}g++;k=Math.round(Q());sa(A,4);l=a.h.transaction(b,e.mode);M=new ti(l);M=ui(M,d);return w(A,M,6);case 6:return m=A.i,p=Math.round(Q()),vi(a,k,p,g,void 0,b.join(),e),A.return(m);case 4:u=ua(A);q=Math.round(Q());x=ci(u,a.h.name,b.join(),a.h.version);
if((y=x instanceof V&&!x.h)||g>=f)vi(a,k,q,g,x,b.join(),e),h=x;A.o(2);break;case 3:return A.return(Promise.reject(h))}})}
function vi(a,b,c,d,e,f,g){b=c-b;e?(e instanceof V&&("QUOTA_EXCEEDED"===e.type||"QUOTA_MAYBE_EXCEEDED"===e.type)&&Rh("QUOTA_EXCEEDED",{dbName:Wh(a.h.name),objectStoreNames:f,transactionCount:a.transactionCount,transactionMode:g.mode}),e instanceof V&&"UNKNOWN_ABORT"===e.type&&(c-=a.j,0>c&&c>=Math.pow(2,31)&&(c=0),Rh("TRANSACTION_UNEXPECTEDLY_ABORTED",{objectStoreNames:f,transactionDuration:b,transactionCount:a.transactionCount,dbDuration:c}),a.i=!0),wi(a,!1,d,f,b,g.tag),Qh(e)):wi(a,!0,d,f,b,g.tag)}
function wi(a,b,c,d,e,f){Rh("TRANSACTION_ENDED",{objectStoreNames:d,connectionHasUnknownAbortedTransaction:a.i,duration:e,isSuccessful:b,tryCount:c,tag:void 0===f?"IDB_TRANSACTION_TAG_UNKNOWN":f})}
n.getName=function(){return this.h.name};
function ri(a){this.h=a}
n=ri.prototype;n.add=function(a,b){return X(this.h.add(a,b))};
n.autoIncrement=function(){return this.h.autoIncrement};
n.clear=function(){return X(this.h.clear()).then(function(){})};
n.count=function(a){return X(this.h.count(a))};
function xi(a,b){return yi(a,{query:b},function(c){return c.delete().then(function(){return c.continue()})}).then(function(){})}
n.delete=function(a){return a instanceof IDBKeyRange?xi(this,a):X(this.h.delete(a))};
n.get=function(a){return X(this.h.get(a))};
n.index=function(a){try{return new zi(this.h.index(a))}catch(b){if(b instanceof Error&&"NotFoundError"===b.name)throw new ai(a,this.h.name);throw b;}};
n.getName=function(){return this.h.name};
n.keyPath=function(){return this.h.keyPath};
function yi(a,b,c){a=a.h.openCursor(b.query,b.direction);return Ai(a).then(function(d){return ni(d,c)})}
function ti(a){var b=this;this.h=a;this.j=new Map;this.i=!1;this.done=new Promise(function(c,d){b.h.addEventListener("complete",function(){c()});
b.h.addEventListener("error",function(e){e.currentTarget===e.target&&d(b.h.error)});
b.h.addEventListener("abort",function(){var e=b.h.error;if(e)d(e);else if(!b.i){e=V;for(var f=b.h.objectStoreNames,g=[],h=0;h<f.length;h++){var k=f.item(h);if(null===k)throw Error("Invariant: item in DOMStringList is null");g.push(k)}e=new e("UNKNOWN_ABORT",{objectStoreNames:g.join(),dbName:b.h.db.name,mode:b.h.mode});d(e)}})})}
function ui(a,b){var c=new Promise(function(d,e){try{hi(b(a).then(function(f){d(f)}),e)}catch(f){e(f),a.abort()}});
return Promise.all([c,a.done]).then(function(d){return t(d).next().value})}
ti.prototype.abort=function(){this.h.abort();this.i=!0;throw new V("EXPLICIT_ABORT");};
ti.prototype.objectStore=function(a){a=this.h.objectStore(a);var b=this.j.get(a);b||(b=new ri(a),this.j.set(a,b));return b};
function zi(a){this.h=a}
n=zi.prototype;n.count=function(a){return X(this.h.count(a))};
n.delete=function(a){return Bi(this,{query:a},function(b){return b.delete().then(function(){return b.continue()})})};
n.get=function(a){return X(this.h.get(a))};
n.getKey=function(a){return X(this.h.getKey(a))};
n.keyPath=function(){return this.h.keyPath};
n.unique=function(){return this.h.unique};
function Bi(a,b,c){a=a.h.openCursor(void 0===b.query?null:b.query,void 0===b.direction?"next":b.direction);return Ai(a).then(function(d){return ni(d,c)})}
function Ci(a,b){this.request=a;this.cursor=b}
function Ai(a){return X(a).then(function(b){return b?new Ci(a,b):null})}
n=Ci.prototype;n.advance=function(a){this.cursor.advance(a);return Ai(this.request)};
n.continue=function(a){this.cursor.continue(a);return Ai(this.request)};
n.delete=function(){return X(this.cursor.delete()).then(function(){})};
n.getKey=function(){return this.cursor.key};
n.X=function(){return this.cursor.value};
n.update=function(a){return X(this.cursor.update(a))};function Di(a,b,c){return new Promise(function(d,e){function f(){u||(u=new oi(g.result,{closed:p}));return u}
var g=void 0!==b?self.indexedDB.open(a,b):self.indexedDB.open(a);var h=c.blocked,k=c.blocking,l=c.sb,m=c.upgrade,p=c.closed,u;g.addEventListener("upgradeneeded",function(q){try{if(null===q.newVersion)throw Error("Invariant: newVersion on IDbVersionChangeEvent is null");if(null===g.transaction)throw Error("Invariant: transaction on IDbOpenDbRequest is null");q.dataLoss&&"none"!==q.dataLoss&&Rh("IDB_DATA_CORRUPTED",{reason:q.dataLossMessage||"unknown reason",dbName:Wh(a)});var x=f(),y=new ti(g.transaction);
m&&m(x,function(A){return q.oldVersion<A&&q.newVersion>=A},y);
y.done.catch(function(A){e(A)})}catch(A){e(A)}});
g.addEventListener("success",function(){var q=g.result;k&&q.addEventListener("versionchange",function(){k(f())});
q.addEventListener("close",function(){Rh("IDB_UNEXPECTEDLY_CLOSED",{dbName:Wh(a),dbVersion:q.version});l&&l()});
d(f())});
g.addEventListener("error",function(){e(g.error)});
h&&g.addEventListener("blocked",function(){h()})})}
function Ei(a,b,c){c=void 0===c?{}:c;return Di(a,b,c)}
function Fi(a,b){b=void 0===b?{}:b;var c,d,e,f;return z(function(g){if(1==g.h)return sa(g,2),c=self.indexedDB.deleteDatabase(a),d=b,(e=d.blocked)&&c.addEventListener("blocked",function(){e()}),w(g,mi(c),4);
if(2!=g.h)return ta(g,0);f=ua(g);throw ci(f,a,"",-1);})}
;function Gi(a){return new Promise(function(b){ng(function(){b()},a)})}
function Hi(a,b){this.name=a;this.options=b;this.l=!0;this.v=this.m=0;this.i=500}
Hi.prototype.j=function(a,b,c){c=void 0===c?{}:c;return Ei(a,b,c)};
Hi.prototype.delete=function(a){a=void 0===a?{}:a;return Fi(this.name,a)};
function Ii(a,b){return new V("INCOMPATIBLE_DB_VERSION",{dbName:a.name,oldVersion:a.options.version,newVersion:b})}
function Ji(a,b){if(!b)throw di("openWithToken",Wh(a.name));return a.open()}
Hi.prototype.open=function(){function a(){var f,g,h,k,l,m,p,u,q,x;return z(function(y){switch(y.h){case 1:return h=null!==(f=Error().stack)&&void 0!==f?f:"",sa(y,2),w(y,c.j(c.name,c.options.version,e),4);case 4:k=y.i;for(var A=c.options,M=[],O=t(Object.keys(A.ga)),P=O.next();!P.done;P=O.next()){P=P.value;var Mb=A.ga[P],Sd=void 0===Mb.rb?Number.MAX_VALUE:Mb.rb;!(k.h.version>=Mb.wa)||k.h.version>=Sd||k.h.objectStoreNames.contains(P)||M.push(P)}l=M;if(0===l.length){y.o(5);break}m=Object.keys(c.options.ga);
p=k.objectStoreNames();if(c.v<fg("ytidb_reopen_db_retries",0))return c.v++,k.close(),Qh(new V("DB_REOPENED_BY_MISSING_OBJECT_STORES",{dbName:c.name,expectedObjectStores:m,foundObjectStores:p})),y.return(a());if(!(c.m<fg("ytidb_remake_db_retries",1))){y.o(6);break}c.m++;if(!N("ytidb_remake_db_enable_backoff_delay")){y.o(7);break}return w(y,Gi(c.i),8);case 8:c.i*=2;case 7:return w(y,c.delete(),9);case 9:return Qh(new V("DB_DELETED_BY_MISSING_OBJECT_STORES",{dbName:c.name,expectedObjectStores:m,foundObjectStores:p})),
y.return(a());case 6:throw new $h(p,m);case 5:return y.return(k);case 2:u=ua(y);if(u instanceof DOMException?"VersionError"!==u.name:"DOMError"in self&&u instanceof DOMError?"VersionError"!==u.name:!(u instanceof Object&&"message"in u)||"An attempt was made to open a database using a lower version than the existing version."!==u.message){y.o(10);break}return w(y,c.j(c.name,void 0,Object.assign(Object.assign({},e),{upgrade:void 0})),11);case 11:q=y.i;x=q.h.version;if(void 0!==c.options.version&&x>
c.options.version+1)throw q.close(),c.l=!1,Ii(c,x);return y.return(q);case 10:throw b(),u instanceof Error&&!N("ytidb_async_stack_killswitch")&&(u.stack=u.stack+"\n"+h.substring(h.indexOf("\n")+1)),ci(u,c.name,"",null!==(g=c.options.version)&&void 0!==g?g:-1);}})}
function b(){c.h===d&&(c.h=void 0)}
var c=this;if(!this.l)throw Ii(this);if(this.h)return this.h;var d,e={blocking:function(f){f.close()},
closed:b,sb:b,upgrade:this.options.upgrade};return this.h=d=a()};var Ki=new Hi("YtIdbMeta",{ga:{databases:{wa:1}},upgrade:function(a,b){b(1)&&qi(a,"databases",{keyPath:"actualName"})}});
function Li(a,b){var c;return z(function(d){if(1==d.h)return w(d,Ji(Ki,b),2);c=d.i;return d.return(pi(c,["databases"],{G:!0,mode:"readwrite"},function(e){var f=e.objectStore("databases");return f.get(a.actualName).then(function(g){if(g?a.actualName!==g.actualName||a.publicName!==g.publicName||a.userIdentifier!==g.userIdentifier:1)return X(f.h.put(a,void 0)).then(function(){})})}))})}
function Mi(a,b){var c;return z(function(d){if(1==d.h)return a?w(d,Ji(Ki,b),2):d.return();c=d.i;return d.return(c.delete("databases",a))})}
function Ni(a,b){var c,d;return z(function(e){return 1==e.h?(c=[],w(e,Ji(Ki,b),2)):3!=e.h?(d=e.i,w(e,pi(d,["databases"],{G:!0,mode:"readonly"},function(f){c.length=0;return yi(f.objectStore("databases"),{},function(g){a(g.X())&&c.push(g.X());return g.continue()})}),3)):e.return(c)})}
function Oi(a){return Ni(function(b){return"LogsDatabaseV2"===b.publicName&&void 0!==b.userIdentifier},a)}
;var Pi,Qi=new function(){}(new function(){});
function Ri(){var a,b,c;return z(function(d){switch(d.h){case 1:a=Nh();if(null===a||void 0===a?0:a.hasSucceededOnce)return d.return(!0);var e;if(e=Lh)e=/WebKit\/([0-9]+)/.exec(ub()),e=!!(e&&600<=parseInt(e[1],10));e&&(e=/WebKit\/([0-9]+)/.exec(ub()),e=!(e&&602<=parseInt(e[1],10)));if(e||Kb)return d.return(!1);try{if(b=self,!(b.indexedDB&&b.IDBIndex&&b.IDBKeyRange&&b.IDBObjectStore))return d.return(!1)}catch(f){return d.return(!1)}if(!("IDBTransaction"in self&&"objectStoreNames"in IDBTransaction.prototype))return d.return(!1);
sa(d,2);c={actualName:"yt-idb-test-do-not-use",publicName:"yt-idb-test-do-not-use",userIdentifier:void 0};return w(d,Li(c,Qi),4);case 4:return w(d,Mi("yt-idb-test-do-not-use",Qi),5);case 5:return d.return(!0);case 2:return ua(d),d.return(!1)}})}
function Si(){if(void 0!==Pi)return Pi;Ph=!0;return Pi=Ri().then(function(a){Ph=!1;var b,c;null!==(b=Mh())&&void 0!==b&&b.h&&(b=Nh(),b={hasSucceededOnce:(null===b||void 0===b?void 0:b.hasSucceededOnce)||a},null===(c=Mh())||void 0===c?void 0:c.set("LAST_RESULT_ENTRY_KEY",b,2592E3,!0));return a})}
function Ti(){return C("ytglobal.idbToken_")||void 0}
function Ui(){var a=Ti();return a?Promise.resolve(a):Si().then(function(b){(b=b?Qi:void 0)&&D("ytglobal.idbToken_",b);return b})}
;new pe;function Vi(a){if(!Th())throw a=new V("AUTH_INVALID",{dbName:a}),Qh(a),a;var b=Uh();return{actualName:a+":"+b,publicName:a,userIdentifier:b}}
function Wi(a,b,c,d){var e,f,g,h,k,l;return z(function(m){switch(m.h){case 1:return f=null!==(e=Error().stack)&&void 0!==e?e:"",w(m,Ui(),2);case 2:g=m.i;if(!g)throw h=di("openDbImpl",a,b),N("ytidb_async_stack_killswitch")||(h.stack=h.stack+"\n"+f.substring(f.indexOf("\n")+1)),Qh(h),h;Vh(a);k=c?{actualName:a,publicName:a,userIdentifier:void 0}:Vi(a);sa(m,3);return w(m,Li(k,g),5);case 5:return w(m,Ei(k.actualName,b,d),6);case 6:return m.return(m.i);case 3:return l=ua(m),sa(m,7),w(m,Mi(k.actualName,
g),9);case 9:ta(m,8);break;case 7:ua(m);case 8:throw l;}})}
function Xi(a,b,c){c=void 0===c?{}:c;return Wi(a,b,!1,c)}
function Yi(a,b,c){c=void 0===c?{}:c;return Wi(a,b,!0,c)}
function Zi(a,b){b=void 0===b?{}:b;var c,d;return z(function(e){if(1==e.h)return w(e,Ui(),2);if(3!=e.h){c=e.i;if(!c)return e.return();Vh(a);d=Vi(a);return w(e,Fi(d.actualName,b),3)}return w(e,Mi(d.actualName,c),0)})}
function $i(a,b,c){a=a.map(function(d){return z(function(e){return 1==e.h?w(e,Fi(d.actualName,b),2):w(e,Mi(d.actualName,c),0)})});
return Promise.all(a).then(function(){})}
function aj(){var a=void 0===a?{}:a;var b,c;return z(function(d){if(1==d.h)return w(d,Ui(),2);if(3!=d.h){b=d.i;if(!b)return d.return();Vh("LogsDatabaseV2");return w(d,Oi(b),3)}c=d.i;return w(d,$i(c,a,b),0)})}
function bj(a,b){b=void 0===b?{}:b;var c;return z(function(d){if(1==d.h)return w(d,Ui(),2);if(3!=d.h){c=d.i;if(!c)return d.return();Vh(a);return w(d,Fi(a,b),3)}return w(d,Mi(a,c),0)})}
;function cj(a){var b,c,d,e,f,g,h,k;this.h=!1;this.potentialEsfErrorCounter=this.i=0;this.handleError=function(){};
this.ba=function(){};
this.now=Date.now;this.ea=!1;this.ab=null!==(b=a.ab)&&void 0!==b?b:100;this.Ya=null!==(c=a.Ya)&&void 0!==c?c:1;this.Wa=null!==(d=a.Wa)&&void 0!==d?d:2592E6;this.Va=null!==(e=a.Va)&&void 0!==e?e:12E4;this.Xa=null!==(f=a.Xa)&&void 0!==f?f:5E3;this.s=null!==(g=a.s)&&void 0!==g?g:void 0;this.oa=!!a.oa;this.na=null!==(h=a.na)&&void 0!==h?h:.1;this.sa=null!==(k=a.sa)&&void 0!==k?k:10;a.handleError&&(this.handleError=a.handleError);a.ba&&(this.ba=a.ba);a.ea&&(this.ea=a.ea);this.A=a.A;this.K=a.K;this.C=a.C;
this.F=a.F;this.S=a.S;this.Fa=a.Fa;this.Ea=a.Ea;this.s&&(!this.A||this.A("networkless_logging"))&&dj(this)}
function dj(a){a.s&&!a.ea&&(a.h=!0,a.oa&&Math.random()<=a.na&&a.C.ib(a.s),ej(a),a.F.D()&&a.ia(),a.F.Y(a.Fa,a.ia.bind(a)),a.F.Y(a.Ea,a.Ja.bind(a)))}
n=cj.prototype;n.writeThenSend=function(a,b){var c=this;b=void 0===b?{}:b;if(this.s&&this.h){var d={url:a,options:b,timestamp:this.now(),status:"NEW",sendCount:0};this.C.set(d,this.s).then(function(e){d.id=e;c.F.D()&&fj(c,d)}).catch(function(e){fj(c,d);
gj(c,e)})}else this.S(a,b)};
n.sendThenWrite=function(a,b,c){var d=this;b=void 0===b?{}:b;if(this.s&&this.h){var e={url:a,options:b,timestamp:this.now(),status:"NEW",sendCount:0};this.A&&this.A("nwl_skip_retry")&&(e.skipRetry=c);if(this.F.D()||this.A&&this.A("nwl_aggressive_send_then_write")&&!e.skipRetry){if(!e.skipRetry){var f=b.onError?b.onError:function(){};
b.onError=function(g,h){return z(function(k){if(1==k.h)return w(k,d.C.set(e,d.s).catch(function(l){gj(d,l)}),2);
f(g,h);k.h=0})}}this.S(a,b,e.skipRetry)}else this.C.set(e,this.s).catch(function(g){d.S(a,b,e.skipRetry);
gj(d,g)})}else this.S(a,b,this.A&&this.A("nwl_skip_retry")&&c)};
n.sendAndWrite=function(a,b){var c=this;b=void 0===b?{}:b;if(this.s&&this.h){var d={url:a,options:b,timestamp:this.now(),status:"NEW",sendCount:0},e=!1,f=b.onSuccess?b.onSuccess:function(){};
d.options.onSuccess=function(g,h){void 0!==d.id?c.C.aa(d.id,c.s):e=!0;c.F.P&&c.A&&c.A("vss_network_hint")&&c.F.P(!0);f(g,h)};
this.S(d.url,d.options);this.C.set(d,this.s).then(function(g){d.id=g;e&&c.C.aa(d.id,c.s)}).catch(function(g){gj(c,g)})}else this.S(a,b)};
n.ia=function(){var a=this;if(!this.s)throw di("throttleSend");this.i||(this.i=this.K.L(function(){var b;return z(function(c){if(1==c.h)return w(c,a.C.Oa("NEW",a.s),2);if(3!=c.h)return b=c.i,b?w(c,fj(a,b),3):(a.Ja(),c.return());a.i&&(a.i=0,a.ia());c.h=0})},this.ab))};
n.Ja=function(){this.K.W(this.i);this.i=0};
function fj(a,b){var c,d;return z(function(e){switch(e.h){case 1:if(!a.s)throw c=di("immediateSend"),c;if(void 0===b.id){e.o(2);break}return w(e,a.C.pb(b.id,a.s),3);case 3:(d=e.i)?b=d:a.ba(Error("The request cannot be found in the database."));case 2:if(hj(a,b,a.Wa)){e.o(4);break}a.ba(Error("Networkless Logging: Stored logs request expired age limit"));if(void 0===b.id){e.o(5);break}return w(e,a.C.aa(b.id,a.s),5);case 5:return e.return();case 4:b.skipRetry||(b=ij(a,b));if(!b){e.o(0);break}if(!b.skipRetry||
void 0===b.id){e.o(8);break}return w(e,a.C.aa(b.id,a.s),8);case 8:a.S(b.url,b.options,!!b.skipRetry),e.h=0}})}
function ij(a,b){if(!a.s)throw di("updateRequestHandlers");var c=b.options.onError?b.options.onError:function(){};
b.options.onError=function(e,f){var g;return z(function(h){switch(h.h){case 1:g=jj(f);if(!(a.A&&a.A("nwl_consider_error_code")&&g||a.A&&!a.A("nwl_consider_error_code")&&a.potentialEsfErrorCounter<=a.sa)){h.o(2);break}if(!a.F.T){h.o(3);break}return w(h,a.F.T(),3);case 3:if(a.F.D()){h.o(2);break}c(e,f);if(!a.A||!a.A("nwl_consider_error_code")||void 0===(null===b||void 0===b?void 0:b.id)){h.o(6);break}return w(h,a.C.Ga(b.id,a.s,!1),6);case 6:return h.return();case 2:if(a.A&&a.A("nwl_consider_error_code")&&
!g&&a.potentialEsfErrorCounter>a.sa)return h.return();a.potentialEsfErrorCounter++;if(void 0===(null===b||void 0===b?void 0:b.id)){h.o(8);break}return b.sendCount<a.Ya?w(h,a.C.Ga(b.id,a.s),12):w(h,a.C.aa(b.id,a.s),8);case 12:a.K.L(function(){a.F.D()&&a.ia()},a.Xa);
case 8:c(e,f),h.h=0}})};
var d=b.options.onSuccess?b.options.onSuccess:function(){};
b.options.onSuccess=function(e,f){return z(function(g){if(1==g.h)return void 0===(null===b||void 0===b?void 0:b.id)?g.o(2):w(g,a.C.aa(b.id,a.s),2);a.F.P&&a.A&&a.A("vss_network_hint")&&a.F.P(!0);d(e,f);g.h=0})};
return b}
function hj(a,b,c){b=b.timestamp;return a.now()-b>=c?!1:!0}
function ej(a){if(!a.s)throw di("retryQueuedRequests");a.C.Oa("QUEUED",a.s).then(function(b){b&&!hj(a,b,a.Va)?a.K.L(function(){return z(function(c){if(1==c.h)return void 0===b.id?c.o(2):w(c,a.C.Ga(b.id,a.s),2);ej(a);c.h=0})}):a.F.D()&&a.ia()})}
function gj(a,b){a.bb&&!a.F.D()?a.bb(b):a.handleError(b)}
function jj(a){var b;return(a=null===(b=null===a||void 0===a?void 0:a.error)||void 0===b?void 0:b.code)&&400<=a&&599>=a?!1:!0}
;var kj=C("ytPubsub2Pubsub2Instance")||new K;K.prototype.subscribe=K.prototype.subscribe;K.prototype.unsubscribeByKey=K.prototype.ja;K.prototype.publish=K.prototype.ca;K.prototype.clear=K.prototype.clear;D("ytPubsub2Pubsub2Instance",kj);D("ytPubsub2Pubsub2SubscribedKeys",C("ytPubsub2Pubsub2SubscribedKeys")||{});D("ytPubsub2Pubsub2TopicToKeys",C("ytPubsub2Pubsub2TopicToKeys")||{});D("ytPubsub2Pubsub2IsAsync",C("ytPubsub2Pubsub2IsAsync")||{});D("ytPubsub2Pubsub2SkipSubKey",null);function lj(a,b){Hi.call(this,a,b);this.options=b;Vh(a)}
v(lj,Hi);function mj(a,b){var c;return function(){c||(c=new lj(a,b));return c}}
lj.prototype.j=function(a,b,c){c=void 0===c?{}:c;return(this.options.Ha?Yi:Xi)(a,b,Object.assign({},c))};
lj.prototype.delete=function(a){a=void 0===a?{}:a;return(this.options.Ha?bj:Zi)(this.name,a)};
function nj(a,b){return mj(a,b)}
;var oj;
function pj(){if(oj)return oj();var a={};oj=nj("LogsDatabaseV2",{ga:(a.LogsRequestsStore={wa:2},a),Ha:!1,upgrade:function(b,c,d){c(2)&&qi(b,"LogsRequestsStore",{keyPath:"id",autoIncrement:!0});c(3);c(5)&&(d=d.objectStore("LogsRequestsStore"),d.h.indexNames.contains("newRequest")&&d.h.deleteIndex("newRequest"),d.h.createIndex("newRequestV2",["status","interface","timestamp"],{unique:!1}));c(7)&&b.h.objectStoreNames.contains("sapisid")&&b.h.deleteObjectStore("sapisid");c(9)&&b.h.objectStoreNames.contains("SWHealthLog")&&b.h.deleteObjectStore("SWHealthLog")},
version:9});return oj()}
;function qj(a){return Ji(pj(),a)}
function rj(a,b){var c,d,e,f;return z(function(g){if(1==g.h)return c={startTime:Q(),transactionType:"YT_IDB_TRANSACTION_TYPE_WRITE"},w(g,qj(b),2);if(3!=g.h)return d=g.i,e=Object.assign(Object.assign({},a),{options:JSON.parse(JSON.stringify(a.options)),interface:L("INNERTUBE_CONTEXT_CLIENT_NAME",0)}),w(g,si(d,e),3);f=g.i;c.tb=Q();sj(c);return g.return(f)})}
function tj(a,b){var c,d,e,f,g,h,k;return z(function(l){if(1==l.h)return c={startTime:Q(),transactionType:"YT_IDB_TRANSACTION_TYPE_READ"},w(l,qj(b),2);if(3!=l.h)return d=l.i,e=L("INNERTUBE_CONTEXT_CLIENT_NAME",0),f=[a,e,0],g=[a,e,Q()],h=IDBKeyRange.bound(f,g),k=void 0,w(l,pi(d,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(m){return Bi(m.objectStore("LogsRequestsStore").index("newRequestV2"),{query:h,direction:"prev"},function(p){p.X()&&(k=p.X(),"NEW"===a&&(k.status="QUEUED",p.update(k)))})}),
3);
c.tb=Q();sj(c);return l.return(k)})}
function uj(a,b){var c;return z(function(d){if(1==d.h)return w(d,qj(b),2);c=d.i;return d.return(pi(c,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(e){var f=e.objectStore("LogsRequestsStore");return f.get(a).then(function(g){if(g)return g.status="QUEUED",X(f.h.put(g,void 0)).then(function(){return g})})}))})}
function vj(a,b,c){c=void 0===c?!0:c;var d;return z(function(e){if(1==e.h)return w(e,qj(b),2);d=e.i;return e.return(pi(d,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(f){var g=f.objectStore("LogsRequestsStore");return g.get(a).then(function(h){return h?(h.status="NEW",c&&(h.sendCount+=1),X(g.h.put(h,void 0)).then(function(){return h})):W.resolve(void 0)})}))})}
function wj(a,b){var c;return z(function(d){if(1==d.h)return w(d,qj(b),2);c=d.i;return d.return(c.delete("LogsRequestsStore",a))})}
function xj(a){var b,c;return z(function(d){if(1==d.h)return w(d,qj(a),2);b=d.i;c=Q()-2592E6;return w(d,pi(b,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(e){return yi(e.objectStore("LogsRequestsStore"),{},function(f){if(f.X().timestamp<=c)return f.delete().then(function(){return f.continue()})})}),0)})}
function yj(){z(function(a){return w(a,aj(),0)})}
function sj(a){if(!N("nwl_csi_killswitch")&&.01>=Math.random()){var b=C("ytPubsub2Pubsub2Instance");b&&b.publish.call(b,"nwl_transaction_latency_payload".toString(),"nwl_transaction_latency_payload",a)}}
;var zj={},Aj=nj("ServiceWorkerLogsDatabase",{ga:(zj.SWHealthLog={wa:1},zj),Ha:!0,upgrade:function(a,b){b(1)&&qi(a,"SWHealthLog",{keyPath:"id",autoIncrement:!0}).h.createIndex("swHealthNewRequest",["interface","timestamp"],{unique:!1})},
version:1});function Bj(a){return Ji(Aj(),a)}
function Cj(a){var b,c;z(function(d){if(1==d.h)return w(d,Bj(a),2);b=d.i;c=Q()-2592E6;return w(d,pi(b,["SWHealthLog"],{mode:"readwrite",G:!0},function(e){return yi(e.objectStore("SWHealthLog"),{},function(f){if(f.X().timestamp<=c)return f.delete().then(function(){return f.continue()})})}),0)})}
function Dj(a){var b;return z(function(c){if(1==c.h)return w(c,Bj(a),2);b=c.i;return w(c,b.clear("SWHealthLog"),0)})}
;var Ej={},Fj=0;function Gj(a){var b=void 0===b?"":b;if(a)if(b)Dg(a,void 0,"POST",b,void 0);else if(L("USE_NET_AJAX_FOR_PING_TRANSPORT",!1))Dg(a,void 0,"GET","",void 0);else{b:{try{var c=new Ua({url:a});if(c.j&&c.i||c.l){var d=zb(a.match(yb)[5]||null);var e=!(!d||!d.endsWith("/aclk")||"1"!==Fb(a,"ri"));break b}}catch(g){}e=!1}if(e){b:{try{if(window.navigator&&window.navigator.sendBeacon&&window.navigator.sendBeacon(a,"")){var f=!0;break b}}catch(g){}f=!1}b=f?!0:!1}else b=!1;b||Ij(a)}}
function Ij(a){var b=new Image,c=""+Fj++;Ej[c]=b;b.onload=b.onerror=function(){delete Ej[c]};
b.src=a}
;function Y(){this.h=new Map;this.i=!1}
function Jj(){if(!Y.h){var a=C("yt.networkRequestMonitor.instance")||new Y;D("yt.networkRequestMonitor.instance",a);Y.h=a}return Y.h}
Y.prototype.requestComplete=function(a,b){b&&(this.i=!0);a=this.removeParams(a);this.h.get(a)||this.h.set(a,b)};
Y.prototype.isEndpointCFR=function(a){a=this.removeParams(a);return(a=this.h.get(a))?!1:!1===a&&this.i?!0:null};
Y.prototype.removeParams=function(a){return a.split("?")[0]};
Y.prototype.removeParams=Y.prototype.removeParams;Y.prototype.isEndpointCFR=Y.prototype.isEndpointCFR;Y.prototype.requestComplete=Y.prototype.requestComplete;Y.getInstance=Jj;var Kj;function Lj(){Kj||(Kj=new Fh("yt.offline"));return Kj}
function Mj(a){if(N("offline_error_handling")){var b=Lj().get("errors",!0)||{};b[a.message]={name:a.name,stack:a.stack};a.level&&(b[a.message].level=a.level);Lj().set("errors",b,2592E3,!0)}}
function Nj(){if(N("offline_error_handling")){var a=Lj().get("errors",!0);if(a){for(var b in a)if(a[b]){var c=new Sh(b,"sent via offline_errors");c.name=a[b].name;c.stack=a[b].stack;c.level=a[b].level;Kf(c)}Lj().set("errors",{},2592E3,!0)}}}
;var Oj=fg("network_polling_interval",3E4);function Z(){J.call(this);this.O=0;this.ka=this.m=!1;this.j=this.ya();N("use_shared_nsm")?(Ad.h||(Ad.h=new Ad(qg)),this.i=Ad.h):(Pj(this),Qj(this))}
v(Z,J);function Rj(){if(!Z.h){var a=C("yt.networkStatusManager.instance")||new Z;D("yt.networkStatusManager.instance",a);Z.h=a}return Z.h}
n=Z.prototype;n.D=function(){var a;return N("use_shared_nsm")&&this.i?null===(a=this.i)||void 0===a?void 0:a.D():this.j};
n.P=function(a){var b;N("use_shared_nsm")&&this.i?null===(b=this.i)||void 0===b?void 0:b.i=a:a!==this.j&&(this.j=a)};
n.qb=function(a){!N("use_shared_nsm")&&(this.m=!0,void 0===a?0:a)&&(this.O||Sj(this))};
n.ya=function(){var a=window.navigator.onLine;return void 0===a?!0:a};
n.kb=function(){this.ka=!0};
n.Y=function(a,b){return N("use_shared_nsm")&&this.i?this.i.Y(a,b):J.prototype.Y.call(this,a,b)};
function Qj(a){window.addEventListener("online",function(){return z(function(b){if(1==b.h)return w(b,a.T(),2);a.ka&&Nj();b.h=0})})}
function Pj(a){window.addEventListener("offline",function(){return z(function(b){return w(b,a.T(),0)})})}
function Sj(a){a.O=lg(function(){return z(function(b){if(1==b.h)return a.j?a.ya()||!a.m?b.o(3):w(b,a.T(),3):w(b,a.T(),3);Sj(a);b.h=0})},Oj)}
n.T=function(a){var b=this;if(N("use_shared_nsm")&&this.i){var c=Bd(this.i,a);c.then(function(d){N("use_cfr_monitor")&&Jj().requestComplete("generate_204",d)});
return c}return this.u?this.u:this.u=new Promise(function(d){var e,f,g;return z(function(h){switch(h.h){case 1:return e=window.AbortController?new window.AbortController:void 0,f=null===e||void 0===e?void 0:e.signal,g=!1,sa(h,2,3),e&&(b.B=qg.L(function(){e.abort()},a||2E4)),w(h,fetch("/generate_204",{method:"HEAD",
signal:f}),5);case 5:g=!0;case 3:va(h);N("use_cfr_monitor")&&Jj().requestComplete("generate_204",g);b.u=void 0;b.B&&qg.W(b.B);g!==b.j&&(b.j=g,b.j&&b.m?yd(b,"ytnetworkstatus-online"):b.m&&yd(b,"ytnetworkstatus-offline"));d(g);xa(h);break;case 2:ua(h),g=!1,h.o(3)}})})};
Z.prototype.sendNetworkCheckRequest=Z.prototype.T;Z.prototype.listen=Z.prototype.Y;Z.prototype.enableErrorFlushing=Z.prototype.kb;Z.prototype.getWindowStatus=Z.prototype.ya;Z.prototype.monitorNetworkStatusChange=Z.prototype.qb;Z.prototype.networkStatusHint=Z.prototype.P;Z.prototype.isNetworkAvailable=Z.prototype.D;Z.getInstance=Rj;function Tj(a){a=void 0===a?{}:a;J.call(this);var b=this;this.j=this.O=0;this.m="ytnetworkstatus-offline";this.u="ytnetworkstatus-online";N("use_shared_nsm")&&(this.m="networkstatus-offline",this.u="networkstatus-online");this.i=Rj();var c=C("yt.networkStatusManager.instance.monitorNetworkStatusChange").bind(this.i);c&&c(a.Ma);a.qa&&!N("use_shared_nsm")&&(c=C("yt.networkStatusManager.instance.enableErrorFlushing").bind(this.i))&&c();if(c=C("yt.networkStatusManager.instance.listen").bind(this.i))a.ta?
(this.ta=a.ta,c(this.u,function(){Uj(b,"publicytnetworkstatus-online");N("use_shared_nsm")&&a.qa&&Nj()}),c(this.m,function(){Uj(b,"publicytnetworkstatus-offline")})):(c(this.u,function(){yd(b,"publicytnetworkstatus-online");
N("use_shared_nsm")&&a.qa&&Nj()}),c(this.m,function(){yd(b,"publicytnetworkstatus-offline")}))}
v(Tj,J);Tj.prototype.D=function(){var a=C("yt.networkStatusManager.instance.isNetworkAvailable");return a?a.bind(this.i)():!0};
Tj.prototype.P=function(a){var b=C("yt.networkStatusManager.instance.networkStatusHint").bind(this.i);b&&b(a)};
Tj.prototype.T=function(a){var b=this,c;return z(function(d){c=C("yt.networkStatusManager.instance.sendNetworkCheckRequest").bind(b.i);return N("skip_network_check_if_cfr")&&Jj().isEndpointCFR("generate_204")?d.return(new Promise(function(e){var f;b.P((null===(f=window.navigator)||void 0===f?void 0:f.onLine)||!0);e(b.D())})):c?d.return(c(a)):d.return(!0)})};
function Uj(a,b){a.ta?a.j?(qg.W(a.O),a.O=qg.L(function(){a.B!==b&&(yd(a,b),a.B=b,a.j=Q())},a.ta-(Q()-a.j))):(yd(a,b),a.B=b,a.j=Q()):yd(a,b)}
;var Vj;function Wj(){cj.call(this,{C:{ib:xj,aa:wj,Oa:tj,pb:uj,Ga:vj,set:rj},F:Xj(),handleError:Kf,ba:Lf,S:Yj,now:Q,bb:Mj,K:pg(),Fa:"publicytnetworkstatus-online",Ea:"publicytnetworkstatus-offline",oa:!0,na:.1,sa:fg("potential_esf_error_limit",10),A:N,ea:!Th()});this.j=new pe;N("networkless_immediately_drop_all_requests")&&yj();bj("LogsDatabaseV2")}
v(Wj,cj);function Zj(){var a=C("yt.networklessRequestController.instance");a||(a=new Wj,D("yt.networklessRequestController.instance",a),N("networkless_logging")&&Ui().then(function(b){a.s=b;dj(a);a.j.resolve();a.oa&&Math.random()<=a.na&&a.s&&Cj(a.s);N("networkless_immediately_drop_sw_health_store")&&ak(a)}));
return a}
Wj.prototype.writeThenSend=function(a,b){b||(b={});Th()||(this.h=!1);cj.prototype.writeThenSend.call(this,a,b)};
Wj.prototype.sendThenWrite=function(a,b,c){b||(b={});Th()||(this.h=!1);cj.prototype.sendThenWrite.call(this,a,b,c)};
Wj.prototype.sendAndWrite=function(a,b){b||(b={});Th()||(this.h=!1);cj.prototype.sendAndWrite.call(this,a,b)};
Wj.prototype.awaitInitialization=function(){return this.j.promise};
function ak(a){var b;z(function(c){if(!a.s)throw b=di("clearSWHealthLogsDb"),b;return c.return(Dj(a.s).catch(function(d){a.handleError(d)}))})}
function Yj(a,b,c){N("use_cfr_monitor")&&bk(a,b);var d;if(null===(d=b.postParams)||void 0===d?0:d.requestTimeMs)b.postParams.requestTimeMs=Math.round(Q());c&&0===Object.keys(b).length?Gj(a):Ag(a,b)}
function Xj(){Vj||(Vj=new Tj({qa:!0,Ma:!0}));return Vj}
function bk(a,b){var c=b.onError?b.onError:function(){};
b.onError=function(e,f){Jj().requestComplete(a,!1);c(e,f)};
var d=b.onSuccess?b.onSuccess:function(){};
b.onSuccess=function(e,f){Jj().requestComplete(a,!0);d(e,f)}}
;var ck=0,dk=0,ek,fk=B.ytNetworklessLoggingInitializationOptions||{isNwlInitialized:!1,potentialEsfErrorCounter:dk};D("ytNetworklessLoggingInitializationOptions",fk);function gk(a,b){function c(d){var e=hk().D();if(!ik()||!d||e&&N("vss_networkless_bypass_write"))jk(a,b);else{var f={url:a,options:b,timestamp:Q(),status:"NEW",sendCount:0};rj(f,d).then(function(g){f.id=g;hk().D()&&kk(f)}).catch(function(g){kk(f);
hk().D()?Kf(g):Mj(g)})}}
b=void 0===b?{}:b;N("skip_is_supported_killswitch")?Ui().then(function(d){c(d)}):c(Ti())}
function lk(a,b){function c(d){if(ik()&&d){var e={url:a,options:b,timestamp:Q(),status:"NEW",sendCount:0},f=!1,g=b.onSuccess?b.onSuccess:function(){};
e.options.onSuccess=function(k,l){N("use_cfr_monitor")&&Jj().requestComplete(e.url,!0);void 0!==e.id?wj(e.id,d):f=!0;N("vss_network_hint")&&hk().P(!0);g(k,l)};
if(N("use_cfr_monitor")){var h=b.onError?b.onError:function(){};
e.options.onError=function(k,l){Jj().requestComplete(e.url,!1);h(k,l)}}jk(e.url,e.options);
rj(e,d).then(function(k){e.id=k;f&&wj(e.id,d)}).catch(function(k){hk().D()?Kf(k):Mj(k)})}else jk(a,b)}
b=void 0===b?{}:b;N("skip_is_supported_killswitch")?Ui().then(function(d){c(d)}):c(Ti())}
function mk(){var a=Ti();if(!a)throw di("throttleSend");ck||(ck=qg.L(function(){var b;return z(function(c){if(1==c.h)return w(c,tj("NEW",a),2);if(3!=c.h)return b=c.i,b?w(c,kk(b),3):(qg.W(ck),ck=0,c.return());ck&&(ck=0,mk());c.h=0})},100))}
function kk(a){var b,c,d;return z(function(e){switch(e.h){case 1:b=Ti();if(!b)throw c=di("immediateSend"),c;if(void 0===a.id){e.o(2);break}return w(e,uj(a.id,b),3);case 3:(d=e.i)?a=d:Lf(Error("The request cannot be found in the database."));case 2:var f=a.timestamp;if(!(2592E6<=Q()-f)){e.o(4);break}Lf(Error("Networkless Logging: Stored logs request expired age limit"));if(void 0===a.id){e.o(5);break}return w(e,wj(a.id,b),5);case 5:return e.return();case 4:a.skipRetry||(a=nk(a));f=a;var g,h;if(null===
(h=null===(g=null===f||void 0===f?void 0:f.options)||void 0===g?void 0:g.postParams)||void 0===h?0:h.requestTimeMs)f.options.postParams.requestTimeMs=Math.round(Q());a=f;if(!a){e.o(0);break}if(!a.skipRetry||void 0===a.id){e.o(8);break}return w(e,wj(a.id,b),8);case 8:jk(a.url,a.options,!!a.skipRetry),e.h=0}})}
function nk(a){var b=Ti();if(!b)throw di("updateRequestHandlers");var c=a.options.onError?a.options.onError:function(){};
a.options.onError=function(e,f){var g;return z(function(h){switch(h.h){case 1:N("use_cfr_monitor")&&Jj().requestComplete(a.url,!1);g=jj(f);if(!(N("nwl_consider_error_code")&&g||!N("nwl_consider_error_code")&&ok()<=fg("potential_esf_error_limit",10))){h.o(2);break}if(N("skip_checking_network_on_cfr_failure")&&(!N("skip_checking_network_on_cfr_failure")||Jj().isEndpointCFR(a.url))){h.o(3);break}return w(h,hk().T(),3);case 3:if(hk().D()){h.o(2);break}c(e,f);if(!N("nwl_consider_error_code")||void 0===
(null===a||void 0===a?void 0:a.id)){h.o(6);break}return w(h,vj(a.id,b,!1),6);case 6:return h.return();case 2:if(N("nwl_consider_error_code")&&!g&&ok()>fg("potential_esf_error_limit",10))return h.return();C("ytNetworklessLoggingInitializationOptions")&&fk.potentialEsfErrorCounter++;dk++;if(void 0===(null===a||void 0===a?void 0:a.id)){h.o(8);break}return 1>a.sendCount?w(h,vj(a.id,b),12):w(h,wj(a.id,b),8);case 12:qg.L(function(){hk().D()&&mk()},5E3);
case 8:c(e,f),h.h=0}})};
var d=a.options.onSuccess?a.options.onSuccess:function(){};
a.options.onSuccess=function(e,f){return z(function(g){if(1==g.h)return N("use_cfr_monitor")&&Jj().requestComplete(a.url,!0),void 0===(null===a||void 0===a?void 0:a.id)?g.o(2):w(g,wj(a.id,b),2);N("vss_network_hint")&&hk().P(!0);d(e,f);g.h=0})};
return a}
function hk(){if(N("use_new_nwl"))return Xj();ek||(ek=new Tj({qa:!0,Ma:!0}));return ek}
function jk(a,b,c){c&&0===Object.keys(b).length?Gj(a):Ag(a,b)}
function ik(){return C("ytNetworklessLoggingInitializationOptions")?fk.isNwlInitialized:!1}
function ok(){return C("ytNetworklessLoggingInitializationOptions")?fk.potentialEsfErrorCounter:dk}
;function pk(a){var b=this;this.config_=null;a?this.config_=a:xh()&&(this.config_=fh());lg(function(){Kh(b)},5E3)}
pk.prototype.isReady=function(){!this.config_&&xh()&&(this.config_=fh());return!!this.config_};
function jh(a,b,c,d){function e(x){x=void 0===x?!1:x;var y;if(d.retry&&"www.youtube-nocookie.com"!=h&&(x||N("skip_ls_gel_retry")||"application/json"!==g.headers["Content-Type"]||(y=Ih(b,c,l,k)),y)){var A=g.onSuccess,M=g.onFetchSuccess;g.onSuccess=function(O,P){Jh(y);A(O,P)};
c.onFetchSuccess=function(O,P){Jh(y);M(O,P)}}try{x&&d.retry&&!d.Ta.bypassNetworkless?(g.method="POST",d.Ta.writeThenSend?N("use_new_nwl")?Zj().writeThenSend(q,g):gk(q,g):N("use_new_nwl")?Zj().sendAndWrite(q,g):lk(q,g)):(g.method="POST",g.postParams||(g.postParams={}),Ag(q,g))}catch(O){if("InvalidAccessError"==O.name)y&&(Jh(y),y=0),Lf(Error("An extension is blocking network request."));
else throw O;}y&&lg(function(){Kh(a)},5E3)}
!L("VISITOR_DATA")&&"visitor_id"!==b&&.01>Math.random()&&Lf(new Sh("Missing VISITOR_DATA when sending innertube request.",b,c,d));if(!a.isReady()){var f=new Sh("innertube xhrclient not ready",b,c,d);Kf(f);throw f;}var g={headers:d.headers||{},method:"POST",postParams:c,postBody:d.postBody,postBodyFormat:d.postBodyFormat||"JSON",onTimeout:function(){d.onTimeout()},
onFetchTimeout:d.onTimeout,onSuccess:function(x,y){if(d.onSuccess)d.onSuccess(y)},
onFetchSuccess:function(x){if(d.onSuccess)d.onSuccess(x)},
onError:function(x,y){if(d.onError)d.onError(y)},
onFetchError:function(x){if(d.onError)d.onError(x)},
timeout:d.timeout,withCredentials:!0};g.headers["Content-Type"]||(g.headers["Content-Type"]="application/json");var h="";(f=a.config_.mb)&&(h=f);var k=a.config_.ob||!1,l=Dh(k,h,d);Object.assign(g.headers,l);(f=g.headers.Authorization)&&!h&&(g.headers["x-origin"]=window.location.origin);var m="/youtubei/"+a.config_.innertubeApiVersion+"/"+b,p={alt:"json"},u=a.config_.nb&&f;u=u&&f.startsWith("Bearer");u||(p.key=a.config_.innertubeApiKey);var q=cg(""+h+m,p||{},!0);N("use_new_nwl")&&Zj().h||!N("use_new_nwl")&&
ik()?Si().then(function(x){e(x)}):e(!1)}
;function qk(a,b){var c=void 0===c?{}:c;var d=pk;L("ytLoggingEventsDefaultDisabled",!1)&&pk==pk&&(d=null);a:{c=void 0===c?{}:c;if(N("lr_drop_other_and_business_payloads")){if(jg[a]||ig[a])break a}else if(N("lr_drop_other_payloads")&&jg[a])break a;var e={},f=Math.round(c.timestamp||Q());e.eventTimeMs=f<Number.MAX_SAFE_INTEGER?f:0;e[a]=b;a=C("_lact",window);a=null==a?-1:Math.max(Date.now()-a,0);e.context={lastActivityMs:String(c.timestamp||!isFinite(a)?-1:a)};N("log_sequence_info_on_gel_web")&&c.Za&&
(a=e.context,b=c.Za,ph[b]=b in ph?ph[b]+1:0,a.sequence={index:ph[b],groupKey:b},c.Ob&&delete ph[c.Za]);(c.Vb?bh:Yg)({endpoint:"log_event",payload:e,da:c.da,xa:c.xa},d)}}
;var rk=[{Da:function(a){return"Cannot read property '"+a.key+"'"},
ra:{Error:[{regexp:/(Permission denied) to access property "([^']+)"/,groups:["reason","key"]}],TypeError:[{regexp:/Cannot read property '([^']+)' of (null|undefined)/,groups:["key","value"]},{regexp:/\u65e0\u6cd5\u83b7\u53d6\u672a\u5b9a\u4e49\u6216 (null|undefined) \u5f15\u7528\u7684\u5c5e\u6027\u201c([^\u201d]+)\u201d/,groups:["value","key"]},{regexp:/\uc815\uc758\ub418\uc9c0 \uc54a\uc74c \ub610\ub294 (null|undefined) \ucc38\uc870\uc778 '([^']+)' \uc18d\uc131\uc744 \uac00\uc838\uc62c \uc218 \uc5c6\uc2b5\ub2c8\ub2e4./,
groups:["value","key"]},{regexp:/No se puede obtener la propiedad '([^']+)' de referencia nula o sin definir/,groups:["key"]},{regexp:/Unable to get property '([^']+)' of (undefined or null) reference/,groups:["key","value"]},{regexp:/(null) is not an object \(evaluating '(?:([^.]+)\.)?([^']+)'\)/,groups:["value","base","key"]}]}},{Da:function(a){return"Cannot call '"+a.key+"'"},
ra:{TypeError:[{regexp:/(?:([^ ]+)?\.)?([^ ]+) is not a function/,groups:["base","key"]},{regexp:/([^ ]+) called on (null or undefined)/,groups:["key","value"]},{regexp:/Object (.*) has no method '([^ ]+)'/,groups:["base","key"]},{regexp:/Object doesn't support property or method '([^ ]+)'/,groups:["key"]},{regexp:/\u30aa\u30d6\u30b8\u30a7\u30af\u30c8\u306f '([^']+)' \u30d7\u30ed\u30d1\u30c6\u30a3\u307e\u305f\u306f\u30e1\u30bd\u30c3\u30c9\u3092\u30b5\u30dd\u30fc\u30c8\u3057\u3066\u3044\u307e\u305b\u3093/,
groups:["key"]},{regexp:/\uac1c\uccb4\uac00 '([^']+)' \uc18d\uc131\uc774\ub098 \uba54\uc11c\ub4dc\ub97c \uc9c0\uc6d0\ud558\uc9c0 \uc54a\uc2b5\ub2c8\ub2e4./,groups:["key"]}]}},{Da:function(a){return a.key+" is not defined"},
ra:{ReferenceError:[{regexp:/(.*) is not defined/,groups:["key"]},{regexp:/Can't find variable: (.*)/,groups:["key"]}]}}];var tk={V:[],U:[{gb:sk,weight:500}]};function sk(a){if("JavaException"===a.name)return!0;a=a.stack;return a.includes("chrome://")||a.includes("chrome-extension://")||a.includes("moz-extension://")}
;function uk(){this.U=[];this.V=[]}
var vk;function wk(){if(!vk){var a=vk=new uk;a.V.length=0;a.U.length=0;tk.V&&a.V.push.apply(a.V,tk.V);tk.U&&a.U.push.apply(a.U,tk.U)}return vk}
;var xk=new K;function yk(a){function b(){return a.charCodeAt(d++)}
var c=a.length,d=0;do{var e=zk(b);if(Infinity===e)break;var f=e>>3;switch(e&7){case 0:e=zk(b);if(2===f)return e;break;case 1:if(2===f)return;d+=8;break;case 2:e=zk(b);if(2===f)return a.substr(d,e);d+=e;break;case 5:if(2===f)return;d+=4;break;default:return}}while(d<c)}
function zk(a){var b=a(),c=b&127;if(128>b)return c;b=a();c|=(b&127)<<7;if(128>b)return c;b=a();c|=(b&127)<<14;if(128>b)return c;b=a();return 128>b?c|(b&127)<<21:Infinity}
;function Ak(a,b,c,d){if(a)if(Array.isArray(a)){var e=d;for(d=0;d<a.length&&!(a[d]&&(e+=Bk(d,a[d],b,c),500<e));d++);d=e}else if("object"===typeof a)for(e in a){if(a[e]){var f=a[e];var g=b;var h=c;g="string"!==typeof f||"clickTrackingParams"!==e&&"trackingParams"!==e?0:(f=yk(atob(f.replace(/-/g,"+").replace(/_/g,"/"))))?Bk(e+".ve",f,g,h):0;d+=g;d+=Bk(e,a[e],b,c);if(500<d)break}}else c[b]=Ck(a),d+=c[b].length;else c[b]=Ck(a),d+=c[b].length;return d}
function Bk(a,b,c,d){c+="."+a;a=Ck(b);d[c]=a;return c.length+a.length}
function Ck(a){try{return("string"===typeof a?a:String(JSON.stringify(a))).substr(0,500)}catch(b){return"unable to serialize "+typeof a+" ("+b.message+")"}}
;var Dk=new Set,Ek=0,Fk=0,Gk=0,Hk=[],Ik=["PhantomJS","Googlebot","TO STOP THIS SECURITY SCAN go/scan"];var Jk={};function Kk(a){return Jk[a]||(Jk[a]=String(a).replace(/\-([a-z])/g,function(b,c){return c.toUpperCase()}))}
;var Lk={},Mk=[],He=new K,Nk={};function Ok(){for(var a=t(Mk),b=a.next();!b.done;b=a.next())b=b.value,b()}
function Pk(a,b){var c;"yt:"===a.tagName.toLowerCase().substr(0,3)?c=a.getAttribute(b):c=a?a.dataset?a.dataset[Kk(b)]:a.getAttribute("data-"+b):null;return c}
function Qk(a){He.ca.apply(He,arguments)}
;function Rk(a){this.h=a||{};a=[this.h,window.YTConfig||{}];for(var b=0;b<a.length;b++)a[b].host&&(a[b].host=a[b].host.toString().replace("http://","https://"))}
function Sk(a,b){a=[a.h,window.YTConfig||{}];for(var c=0;c<a.length;c++){var d=a[c][b];if(void 0!==d)return d}return null}
function Tk(a,b,c){Uk||(Uk={},Tf(window,"message",function(d){a:{if(d.origin===Sk(a,"host")){try{var e=JSON.parse(d.data)}catch(f){e=void 0;break a}if(d=Uk[e.id])d.u=!0,d.u&&(F(d.v,d.sendMessage,d),d.v.length=0),d.Ia(e)}e=void 0}return e}));
Uk[c]=b}
var Uk=null;function Vk(a,b,c){this.m=this.h=this.i=null;this.j=0;this.u=!1;this.v=[];this.l=null;this.I={};if(!a)throw Error("YouTube player element ID required.");this.id=Ma(this);this.B=c;this.setup(a,b)}
n=Vk.prototype;n.setSize=function(a,b){this.h.width=a.toString();this.h.height=b.toString();return this};
n.getIframe=function(){return this.h};
n.Ia=function(a){Wk(this,a.event,a)};
n.addEventListener=function(a,b){var c=b;"string"===typeof b&&(c=function(){window[b].apply(window,arguments)});
if(!c)return this;this.l.subscribe(a,c);Xk(this,a);return this};
function Yk(a,b){b=b.split(".");if(2===b.length){var c=b[1];a.B===b[0]&&Xk(a,c)}}
n.destroy=function(){this.h&&this.h.id&&(Lk[this.h.id]=null);var a=this.l;a&&"function"==typeof a.dispose&&a.dispose();if(this.m){a=this.h;var b=a.parentNode;b&&b.replaceChild(this.m,a)}else(a=this.h)&&a.parentNode&&a.parentNode.removeChild(a);Uk&&(Uk[this.id]=null);this.i=null;a=this.h;for(var c in db)db[c][0]==a&&Rf(c);this.m=this.h=null};
n.La=function(){return{}};
function Zk(a,b,c){c=c||[];c=Array.prototype.slice.call(c);b={event:"command",func:b,args:c};a.u?a.sendMessage(b):a.v.push(b)}
function Wk(a,b,c){a.l.l||(c={target:a,data:c},a.l.ca(b,c),Qk(a.B+"."+b,c))}
function $k(a,b){var c=document.createElement("iframe");b=b.attributes;for(var d=0,e=b.length;d<e;d++){var f=b[d].value;null!=f&&""!==f&&"null"!==f&&c.setAttribute(b[d].name,f)}c.setAttribute("frameBorder","0");c.setAttribute("allowfullscreen","1");c.setAttribute("allow","accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture");c.setAttribute("title","YouTube "+Sk(a.i,"title"));(b=Sk(a.i,"width"))&&c.setAttribute("width",b.toString());(b=Sk(a.i,"height"))&&c.setAttribute("height",
b.toString());var g=a.La();g.enablejsapi=window.postMessage?1:0;window.location.host&&(g.origin=window.location.protocol+"//"+window.location.host);g.widgetid=a.id;window.location.href&&F(["debugjs","debugcss"],function(h){var k=Fb(window.location.href,h);null!==k&&(g[h]=k)});
window.yt_embedsTokenValue&&(g.embedsTokenValue=encodeURIComponent(window.yt_embedsTokenValue),delete window.yt_embedsTokenValue);c.src=Sk(a.i,"host")+("/embed/"+Sk(a.i,"videoId"))+"?"+Db(g);return c}
n.Ua=function(){this.h&&this.h.contentWindow?this.sendMessage({event:"listening"}):window.clearInterval(this.j)};
function al(a){Tk(a.i,a,a.id);a.j=Vf(a.Ua.bind(a));Tf(a.h,"load",function(){window.clearInterval(a.j);a.j=Vf(a.Ua.bind(a))})}
n.setup=function(a,b){var c=document;if(a="string"===typeof a?c.getElementById(a):a)if(c="iframe"===a.tagName.toLowerCase(),b.host||(b.host=c?Bb(a.src):"https://www.youtube.com"),this.i=new Rk(b),c||(b=$k(this,a),this.m=a,(c=a.parentNode)&&c.replaceChild(b,a),a=b),this.h=a,this.h.id||(this.h.id="widget"+Ma(this.h)),Lk[this.h.id]=this,window.postMessage){this.l=new K;al(this);b=Sk(this.i,"events");for(var d in b)b.hasOwnProperty(d)&&this.addEventListener(d,b[d]);for(var e in Nk)Nk.hasOwnProperty(e)&&
Yk(this,e)}};
function Xk(a,b){a.I[b]||(a.I[b]=!0,Zk(a,"addEventListener",[b]))}
n.sendMessage=function(a){a.id=this.id;a.channel="widget";a=oe(a);var b=[Bb(this.h.src||"").replace("http:","https:")];if(this.h.contentWindow)for(var c=0;c<b.length;c++)try{this.h.contentWindow.postMessage(a,b[c])}catch(A){if(A.name&&"SyntaxError"===A.name){if(!(A.message&&0<A.message.indexOf("target origin ''"))){var d=void 0,e=A;d=void 0===d?{}:d;d.name=L("INNERTUBE_CONTEXT_CLIENT_NAME",1);d.version=L("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0);var f=d||{};d="WARNING";d=void 0===d?"ERROR":d;if(e){e.hasOwnProperty("level")&&
e.level&&(d=e.level);if(N("console_log_js_exceptions")){var g=e,h=[];h.push("Name: "+g.name);h.push("Message: "+g.message);g.hasOwnProperty("params")&&h.push("Error Params: "+JSON.stringify(g.params));g.hasOwnProperty("args")&&h.push("Error args: "+JSON.stringify(g.args));h.push("File name: "+g.fileName);h.push("Stacktrace: "+g.stack);window.console.log(h.join("\n"),g)}if(!(5<=Ek)){g=void 0;var k=f,l=Xc(e);f=l.message||"Unknown Error";h=l.name||"UnknownError";var m=l.stack||e.i||"Not available";if(m.startsWith(h+
": "+f)){var p=m.split("\n");p.shift();m=p.join("\n")}p=l.lineNumber||"Not available";l=l.fileName||"Not available";var u=0;if(e.hasOwnProperty("args")&&e.args&&e.args.length)for(g=0;g<e.args.length&&!(u=Ak(e.args[g],"params."+g,k,u),500<=u);g++);else if(e.hasOwnProperty("params")&&e.params){var q=e.params;if("object"===typeof e.params)for(g in q){if(q[g]){var x="params."+g,y=Ck(q[g]);k[x]=y;u+=x.length+y.length;if(500<u)break}}else k.params=Ck(q)}if(Hk.length)for(g=0;g<Hk.length&&!(u=Ak(Hk[g],"params.context."+
g,k,u),500<=u);g++);navigator.vendor&&!k.hasOwnProperty("vendor")&&(k["device.vendor"]=navigator.vendor);g={message:f,name:h,lineNumber:p,fileName:l,stack:m,params:k,sampleWeight:1};f=Number(e.columnNumber);isNaN(f)||(g.lineNumber=g.lineNumber+":"+f);if("IGNORED"===e.level)e=0;else a:{e=wk();f=t(e.V);for(h=f.next();!h.done;h=f.next())if(h=h.value,g.message&&g.message.match(h.Sb)){e=h.weight;break a}e=t(e.U);for(f=e.next();!f.done;f=e.next())if(f=f.value,f.gb(g)){e=f.weight;break a}e=1}g.sampleWeight=
e;e=g;g=t(rk);for(f=g.next();!f.done;f=g.next())if(f=f.value,f.ra[e.name])for(p=t(f.ra[e.name]),h=p.next();!h.done;h=p.next())if(l=h.value,h=e.message.match(l.regexp)){e.params["params.error.original"]=h[0];p=l.groups;l={};for(m=0;m<p.length;m++)l[p[m]]=h[m+1],e.params["params.error."+p[m]]=h[m+1];e.message=f.Da(l);break}e.params||(e.params={});g=wk();e.params["params.errorServiceSignature"]="msg="+g.V.length+"&cb="+g.U.length;e.params["params.serviceWorker"]="false";B.document&&B.document.querySelectorAll&&
(e.params["params.fscripts"]=String(document.querySelectorAll("script:not([nonce])").length));kb("sample").constructor!==jb&&(e.params["params.fconst"]="true");window.yterr&&"function"===typeof window.yterr&&window.yterr(e);if(0!==e.sampleWeight&&!Dk.has(e.message)){"ERROR"===d?(xk.ca("handleError",e),N("record_app_crashed_web")&&0===Gk&&1===e.sampleWeight&&(Gk++,g={appCrashType:"APP_CRASH_TYPE_BREAKPAD"},N("report_client_error_with_app_crash_ks")||(g.systemHealth={crashData:{clientError:{logMessage:{message:e.message}}}}),
qk("appCrashed",g)),Fk++):"WARNING"===d&&xk.ca("handleWarning",e);if(N("kevlar_gel_error_routing")){g=d;f=e;b:{h=t(Ik);for(p=h.next();!p.done;p=h.next())if((l=ub())&&0<=l.toLowerCase().indexOf(p.value.toLowerCase())){h=!0;break b}h=!1}if(h)f=void 0;else{p={stackTrace:f.stack};f.fileName&&(p.filename=f.fileName);h=f.lineNumber&&f.lineNumber.split?f.lineNumber.split(":"):[];0!==h.length&&(1!==h.length||isNaN(Number(h[0]))?2!==h.length||isNaN(Number(h[0]))||isNaN(Number(h[1]))||(p.lineNumber=Number(h[0]),
p.columnNumber=Number(h[1])):p.lineNumber=Number(h[0]));h={level:"ERROR_LEVEL_UNKNOWN",message:f.message,errorClassName:f.name,sampleWeight:f.sampleWeight};"ERROR"===g?h.level="ERROR_LEVEL_ERROR":"WARNING"===g&&(h.level="ERROR_LEVEL_WARNNING");p={isObfuscated:!0,browserStackInfo:p};l={pageUrl:window.location.href,kvPairs:[]};L("FEXP_EXPERIMENTS")&&(l.experimentIds=L("FEXP_EXPERIMENTS"));m=Gf();k=(k=zf.EXPERIMENT_FLAGS)?k.web_disable_gel_stp_ecatcher_killswitch:void 0;if(!k&&m)for(u=t(Object.keys(m)),
k=u.next();!k.done;k=u.next())k=k.value,l.kvPairs.push({key:k,value:String(m[k])});if(f=f.params)for(m=t(Object.keys(f)),k=m.next();!k.done;k=m.next())k=k.value,l.kvPairs.push({key:"client."+k,value:String(f[k])});f=L("SERVER_NAME",void 0);m=L("SERVER_VERSION",void 0);f&&m&&(l.kvPairs.push({key:"server.name",value:f}),l.kvPairs.push({key:"server.version",value:m}));f={errorMetadata:l,stackTrace:p,logMessage:h}}f&&(qk("clientError",f),("ERROR"===g||N("errors_flush_gel_always_killswitch"))&&$g())}if(!N("suppress_error_204_logging")){f=
e;g=f.params||{};d={urlParams:{a:"logerror",t:"jserror",type:f.name,msg:f.message.substr(0,250),line:f.lineNumber,level:d,"client.name":g.name},postParams:{url:L("PAGE_NAME",window.location.href),file:f.fileName},method:"POST"};g.version&&(d["client.version"]=g.version);if(d.postParams){f.stack&&(d.postParams.stack=f.stack);f=t(Object.keys(g));for(h=f.next();!h.done;h=f.next())h=h.value,d.postParams["client."+h]=g[h];if(g=Gf())for(f=t(Object.keys(g)),h=f.next();!h.done;h=f.next())h=h.value,d.postParams[h]=
g[h];g=L("SERVER_NAME",void 0);f=L("SERVER_VERSION",void 0);g&&f&&(d.postParams["server.name"]=g,d.postParams["server.version"]=f)}Ag(L("ECATCHER_REPORT_HOST","")+"/error_204",d)}try{Dk.add(e.message)}catch(M){}Ek++}}}}}else throw A;}else console&&console.warn&&console.warn("The YouTube player is not attached to the DOM. API calls should be made after the onReady event. See more: https://developers.google.com/youtube/iframe_api_reference#Events")};function bl(a){return(0===a.search("cue")||0===a.search("load"))&&"loadModule"!==a}
function cl(a){return 0===a.search("get")||0===a.search("is")}
;function dl(a,b){Vk.call(this,a,Object.assign({title:"video player",videoId:"",width:640,height:360},b||{}),"player");this.M={};this.playerInfo={}}
v(dl,Vk);n=dl.prototype;n.La=function(){var a=Sk(this.i,"playerVars");if(a){var b={},c;for(c in a)b[c]=a[c];a=b}else a={};window!==window.top&&document.referrer&&(a.widget_referrer=document.referrer.substring(0,256));if(c=Sk(this.i,"embedConfig")){if(La(c))try{c=JSON.stringify(c)}catch(d){console.error("Invalid embed config JSON",d)}a.embed_config=c}return a};
n.Ia=function(a){var b=a.event;a=a.info;switch(b){case "apiInfoDelivery":if(La(a))for(var c in a)a.hasOwnProperty(c)&&(this.M[c]=a[c]);break;case "infoDelivery":el(this,a);break;case "initialDelivery":La(a)&&(window.clearInterval(this.j),this.playerInfo={},this.M={},fl(this,a.apiInterface),el(this,a));break;default:Wk(this,b,a)}};
function el(a,b){if(La(b))for(var c in b)b.hasOwnProperty(c)&&(a.playerInfo[c]=b[c])}
function fl(a,b){F(b,function(c){this[c]||("getCurrentTime"===c?this[c]=function(){var d=this.playerInfo.currentTime;if(1===this.playerInfo.playerState){var e=(Date.now()/1E3-this.playerInfo.currentTimeLastUpdated_)*this.playerInfo.playbackRate;0<e&&(d+=Math.min(e,1))}return d}:bl(c)?this[c]=function(){this.playerInfo={};
this.M={};Zk(this,c,arguments);return this}:cl(c)?this[c]=function(){var d=0;
0===c.search("get")?d=3:0===c.search("is")&&(d=2);return this.playerInfo[c.charAt(d).toLowerCase()+c.substr(d+1)]}:this[c]=function(){Zk(this,c,arguments);
return this})},a)}
n.getVideoEmbedCode=function(){var a=Sk(this.i,"host")+("/embed/"+Sk(this.i,"videoId")),b=Number(Sk(this.i,"width")),c=Number(Sk(this.i,"height"));if(isNaN(b)||isNaN(c))throw Error("Invalid width or height property");b=Math.floor(b);c=Math.floor(c);tb.test(a)&&(-1!=a.indexOf("&")&&(a=a.replace(nb,"&amp;")),-1!=a.indexOf("<")&&(a=a.replace(ob,"&lt;")),-1!=a.indexOf(">")&&(a=a.replace(pb,"&gt;")),-1!=a.indexOf('"')&&(a=a.replace(qb,"&quot;")),-1!=a.indexOf("'")&&(a=a.replace(rb,"&#39;")),-1!=a.indexOf("\x00")&&
(a=a.replace(sb,"&#0;")));return'<iframe width="'+b+'" height="'+c+'" src="'+a+'" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'};
n.getOptions=function(a){return this.M.namespaces?a?this.M[a]?this.M[a].options||[]:[]:this.M.namespaces||[]:[]};
n.getOption=function(a,b){if(this.M.namespaces&&a&&b&&this.M[a])return this.M[a][b]};
function gl(a){if("iframe"!==a.tagName.toLowerCase()){var b=Pk(a,"videoid");b&&(b={videoId:b,width:Pk(a,"width"),height:Pk(a,"height")},new dl(a,b))}}
;D("YT.PlayerState.UNSTARTED",-1);D("YT.PlayerState.ENDED",0);D("YT.PlayerState.PLAYING",1);D("YT.PlayerState.PAUSED",2);D("YT.PlayerState.BUFFERING",3);D("YT.PlayerState.CUED",5);D("YT.get",function(a){return Lk[a]});
D("YT.scan",Ok);D("YT.subscribe",function(a,b,c){He.subscribe(a,b,c);Nk[a]=!0;for(var d in Lk)Lk.hasOwnProperty(d)&&Yk(Lk[d],a)});
D("YT.unsubscribe",function(a,b,c){Ge(a,b,c)});
D("YT.Player",dl);Vk.prototype.destroy=Vk.prototype.destroy;Vk.prototype.setSize=Vk.prototype.setSize;Vk.prototype.getIframe=Vk.prototype.getIframe;Vk.prototype.addEventListener=Vk.prototype.addEventListener;dl.prototype.getVideoEmbedCode=dl.prototype.getVideoEmbedCode;dl.prototype.getOptions=dl.prototype.getOptions;dl.prototype.getOption=dl.prototype.getOption;
Mk.push(function(a){var b=a;b||(b=document);a=$a(b.getElementsByTagName("yt:player"));var c=b||document;if(c.querySelectorAll&&c.querySelector)b=c.querySelectorAll(".yt-player");else{var d;c=document;b=b||c;if(b.querySelectorAll&&b.querySelector)b=b.querySelectorAll(".yt-player");else if(b.getElementsByClassName){var e=b.getElementsByClassName("yt-player");b=e}else{e=b.getElementsByTagName("*");var f={};for(c=d=0;b=e[c];c++){var g=b.className,h;if(h="function"==typeof g.split)h=0<=Wa(g.split(/\s+/),
"yt-player");h&&(f[d++]=b)}f.length=d;b=f}}b=$a(b);F(Za(a,b),gl)});
"undefined"!=typeof YTConfig&&YTConfig.parsetags&&"onload"!=YTConfig.parsetags||Ok();var hl=B.onYTReady;hl&&hl();var il=B.onYouTubeIframeAPIReady;il&&il();var jl=B.onYouTubePlayerAPIReady;jl&&jl();}).call(this);
