/* 
Challenge: Improve renewal rate of subscriptions
You've been asked to add a feature to your company's software. 
The feature is intended to improve the renewal rate of subscriptions to the software. 
Your task is to display a renewal message when a user logs into the software system and 
is notified their subscription will soon end. You'll need to add a couple of decision 
statements to properly add branching logic to the application to satisfy the requirements.
*/

/*
Regras de negócio: 

#1 - Só pode mostrar uma mensagem;
#2 - Se a assinatura expira em 180 dias: "Your subscription will expire soon. Renew now!"
#3 - Se a assinatura expira em 90 dias; "Your subscription expires in _ days.
                                         Renew now and save 10%"
#4 = Se a assinatura expira em 7 dia: "Your subscription expires within a day!"
                                        Renew now and save 20%!
#5 - Se a assinatura já está expirada: "Your subscription has expired."
#6 - Se a assinatura não expira em menos que 180 dias, não mostrar nada. 

*/



Random random = new Random();

int daysUntilExpiration = random.Next(366); // Gera números de 0 a 365
int discountPercentage = 0;


//===========================================================================//


if (daysUntilExpiration > 180);

else if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscription has expired.");}

else if (daysUntilExpiration >= 90 && daysUntilExpiration < 180)
{
    
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew Now and save {discountPercentage}%");
}
else if(discountPercentage <90 && discountPercentage <= 180)
{
    
    Console.WriteLine("Your subscription will expire son. Renew now!");
}
else
{

    discountPercentage = 21;
    Console.WriteLine($"Your subscription expires this week.\nRenew now and save {20}%");
}