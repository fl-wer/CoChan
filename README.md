# Co Chan

[![CodeFactor](https://www.codefactor.io/repository/github/fl-wer/cochan/badge)](https://www.codefactor.io/repository/github/fl-wer/cochan)  
Converts exported comments with https://github.com/egbertbouman/youtube-comment-downloader from YouTube videos into new file with a list of channel links.

![please](https://user-images.githubusercontent.com/101416707/169377097-bb8c8920-f02f-4ce7-aa55-3e07ef16b6ae.png)

# How To Use?
Put in the same directory with "exp.txt" files.  
These files have to have a number, if we had 3 files they would be named like this.  
- exp1.txt  
- exp2.txt  
- exp3.txt  

# Bear In Mind
If you miss one of the numbers between it will stop and not process higher numbers.  
For example, with files as per below only exp1.txt will be processed.  
This is because loop will break if it won't find exp2.txt  
- exp1.txt  
- exp3.txt  
