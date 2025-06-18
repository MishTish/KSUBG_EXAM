from InsufficientFundsException import InsufficientFundsException
from Logger import Logger


class BankAccount:
    def __init__(self, account_number, initial_balance=0.0):
        self.account_number = account_number
        self.balance = initial_balance
        self.logger = Logger()
        self.logger.log(f"Account {self.account_number} created with balance ${self.balance:.2f}")

    def deposit(self, amount):
        if amount <= 0:
            raise ValueError("Deposit amount must be positive")
        self.balance += amount
        self.logger.log(f"Deposited ${amount:.2f} into account {self.account_number}. New balance: ${self.balance:.2f}")

    def withdraw(self, amount):
        if amount <= 0:
            raise ValueError("Withdraw amount must be positive")
        if amount > self.balance:
            self.logger.log(f"Failed withdrawal of ${amount:.2f} from account {self.account_number}. Insufficient funds.")
            raise InsufficientFundsException("Insufficient funds for withdrawal")
        self.balance -= amount
        self.logger.log(f"Withdrew ${amount:.2f} from account {self.account_number}. New balance: ${self.balance:.2f}")