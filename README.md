# Open Closed Principle in SOLID

### What is Open Closed Principle in SOLID?

`The Open Closed Principle is one of the SOLID principles defined by Robert C. Martin. The principle says “software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification”.
So in simple words it says that an implementation (of a class or function), once created, should be closed for further modification, in other words one should not modify an implementation (of a class or function) of logic and/or functionality. One can do refactoring or resolve errors of implementation (of a class or function) but the implementation (of a class or function) is open for extension, in other words one can extend the implementation (of a class or function) of logic and/or functionality.`


### Real life example of Open Closed Principle in SOLID

`An electrical adapter is good example of Open closed principle :`

`Are you can seee this image :`

<img alt="" class=""  src="https://www.c-sharpcorner.com/UploadFile/pranayamr/open-close-principle/Images/img2.jpg">
<img alt="" class=""  src="https://www.c-sharpcorner.com/UploadFile/pranayamr/open-close-principle/Images/img3.jpg">
<img alt="" class=""  src="https://www.c-sharpcorner.com/UploadFile/pranayamr/open-close-principle/Images/img1.jpg">

## Now brief this image :

<ol> <li>An adapter in the wall is always closed for modification, in other words we cannot change it once it is fitted or extended if we want more. 
<br><br></li><li>But an adapter always provides a method of extension, so we can plug in an extension board of an adapter for more adaptation. 
<br><br></li><li>So you plug in an extension board and extend an existing electric adapter fitted in wall. </li></ol>

### Disadvantage of not following Open Closed Principle

<ol> <li>Since a class or function always allows the addition of new logic, whenever new logic is added it is always necessary to test for full functionality. That requires the addition of a new test case for the added functionality and might also require the modification of an existing test case that fails because of added functionality.<br><br> </li><li>It also breaks the Single Responsibility Principle since a class&nbsp;or function might end up doing multiple tasks.<br><br> </li><li>Class or function maintenance becomes difficult since a class or function can become thousands of lines of code that is difficult to understand. </li></ol>
