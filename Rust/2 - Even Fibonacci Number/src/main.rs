fn main() {
    print!("Please enter a number: ");
    let input=get_input(); 
    let n: i32 = input.parse().unwrap_or(0);
    let mut sum: i32=0;
    let mut a: i32=0;
    let mut b:i32=1;
    let mut c:i32=0;

    while c<= n{
        c=a+b;
        a=b;
        b=c;
        if c % 2 == 0{
            sum += c;
        }
    }

    println!("Sum of Even Fibonacci Numbers = {0}", sum);
}

fn get_input() -> String {
       use std::io::{stdin,stdout,Write};
    let mut s=String::new();
    let _=stdout().flush();
    stdin().read_line(&mut s).expect("Did not enter a correct string");
    if let Some('\n')=s.chars().next_back() {
        s.pop();
    }
    if let Some('\r')=s.chars().next_back() {
        s.pop();
    }
   return s;
}
