In this Lab assignment, you will create an application that displays the phrase “Good Morning” in different languages. The form will have three buttons: one for Italian, one for Spanish, and one for German. When the user clicks any of these buttons, the translated phrase will appear in a Label control.

Step 1 (1pts): Start Visual Studio and begin a new Windows Forms App project named Translator.

Step 2 (5pts): Set up the application’s form as shown in Figure below. Notice that the form’s Text property is set to Translator. The form has two Label controls and three Button controls. The names of the controls are shown in the figure. As you place each of the controls on the form, refer to the table below for the relevant property settings.


Step 3 (4pts): Once you have the form and its controls set up, you can create the Click event handlers for the Button controls. In the Designer, double-click the italianButton control. This will open the code editor, and you will see an empty event handler named italianButton_Click. Write the following statement inside the event handler: 

translationLabel.Text = "Buongiorno";

Step 4 (4pts): Switch your view back to the Designer and double-click the spanishButton control. In the code editor you will see an empty event handler named spanishButton_Click. Write the following statement inside the event handler: 

translationLabel.Text = "Buenos Dias";

Step 5 (4pts): Switch your view back to the Designer and double-click the germanButton control. In the code editor you will see an empty event handler named germanButton_Click. Write the following statement inside the event handler: 

translationLabel.Text = "Guten Morgen";

Step 6: Save the project. Then, press the [F5] key on the keyboard or click the Start Debugging button on the toolbar to compile and run the application. The figure below shows the application’s form when it starts running and after you have clicked each of the Button controls. After you have tested each button, close the application’s form.

Step 7 (2 pts): compress your folder and submit. You must upload a compressed file which includes all the documents for this lab assignment to Canvas.