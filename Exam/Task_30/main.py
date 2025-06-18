from BankAccount import BankAccount
from InsufficientFundsException import InsufficientFundsException
from Logger import Logger

if __name__ == "__main__":
    account = BankAccount("1984", 23.00)
    account.deposit(30)

    try:
        account.withdraw(200)
    except InsufficientFundsException as e:
        print(f"[ERROR] {e}")

    # Show all logs
    print("\nTransaction Log:")
    for log in Logger().get_logs():
        print(log)