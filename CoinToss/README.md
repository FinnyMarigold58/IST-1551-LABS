Simulating Coin Tosses

In this tutorial, you create an application that simulates the tossing of a coin. Each time the user tosses the coin, the application uses a Random object to get a random integer in the range of 0 through 1. If the random number is 0, it means the tails side of the coin is up, and if the random number is 1, it means the heads side is up. The application displays an image of a coin showing either heads or tails, depending on the value of the random number.

Step 1 (1pt): Start Visual Studio and begin a new Windows Forms App project named CoinToss.

Step 2 (6pts): Set up the application’s form as shown in the figure below using the two images: Heads1.bmp and Tails1.bmp. Notice that the form’s Text property is set to Coin Toss. The names of the controls are shown in the figure. As you place each of the controls on the form, refer to table below for the relevant property settings. (Make sure the headsPictureBox control’s Visible property is set to True, and the tailsPictureBox control’s Visible property is set to False. This will cause the coin to initially appear heads up when the application runs.)

Step 3 (2pts): After you have set all of the control properties, move the PictureBox controls so one is on top of the other, as shown in the figure below (In the figure, the tailsPictureBox control is on top, but it really doesn’t matter which is on top.) Also, reduce the width of the form and position the button controls as shown in the figure.

Step 4 (8pts): Now you will create the Click event handlers for the two Button controls. In the Designer, double-click the tossButton control. This opens the code editor, and you will see an empty event handler named tossButton_Click. Complete the tossButton_Click event handler by typing the code to get a random number and display an image of a coin showing either heads or tails, depending on the value of the random number. Switch your view back to the Designer and double-click the exitButton control. In the code editor you will see an empty event handler named exitButton_Click. Complete the code for the exitButton_Click event handler.

Step 5 (2pts): Save the project. When the application runs, click the Toss button several times to simulate several coin tosses. When you are finished, click the Exit button to exit the application.

Step 6 (1pt): Compress your project folder and submit. You must upload a .zip file which includes all the documents for this lab assignment to Canvas.