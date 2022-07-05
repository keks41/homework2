bool isPalindrome(int x){
    int div = 1;

    while ((x/div)>=10) div *=10;
    
    while(x!=0)
    {
        int l = x / div;
        int r = x % 10;
        if(l!=r)
        {
            Console.WriteLine(" Not Palindrome");
            return false;
        }
        x = (x % div) /10;
        div/=100;
        
    } 
    Console.WriteLine("number isPalindrome");
    return true;
        
    
}
isPalindrome(12321);




