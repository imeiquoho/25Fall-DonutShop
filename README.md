# ☕🍩 Coffee & Donut Shop Ordering App  
**Course:** SODV / Windows Forms Development  
**Learning Activity:** Custom Controls, Derived Controls, Owner-Drawn Controls  
**Student:** Ime Iquoho  
**Term:** Fall 2025  

---

## 📌 Project Overview

This Windows Forms application simulates a **coffee and donut ordering system** for a local donut shop.  
Users can dynamically add coffee and donut orders, customize each item, and generate a formatted receipt with pricing and totals.

The project was built incrementally following **Lessons 2–5 of the GLA**, focusing on **custom controls**, **derived controls**, **owner-drawn UI**, and **event-driven design**.

---

## 🎯 Features Implemented

### ✅ Coffee Orders (User Control)
- Selectable size: **Small, Medium, Large**
- Adjustable **cream** and **sugar** quantities
- Optional **whipped cream**
- Each coffee order is independently customizable
- Dynamic pricing based on selections

### ✅ Donut Orders (Derived Control)
- Selectable donut flavor
- Quantity selection restricted to **1, 6, 12, or 24**
- Implemented using a **NumericUpDown-derived control**
- Automatic stepping through valid quantities
- Per-item pricing

### ✅ Dynamic Order Container
- Scrollable container that holds multiple orders
- Supports adding unlimited coffee and donut orders
- Clear last item or clear all items
- Maintains proper layout positioning

### ✅ Receipt Display (Owner-Drawn Control)
- Custom-drawn receipt area
- Displays shop title and divider
- Lists all ordered items with bullet formatting
- Shows individual prices and **final total**
- Updates when “Pay and Print Receipt” is clicked

---

## 💲 Pricing Logic

### Coffee Pricing
| Item | Price |
|----|----|
| Small | $2.00 |
| Medium | $3.00 |
| Large | $4.00 |
| Cream (each) | $0.25 |
| Sugar (each) | $0.15 |
| Whipped Cream | $0.50 |

### Donut Pricing
| Item | Price |
|----|----|
| Each donut | $1.25 |

---

## 🧱 Project Structure

25Fall-DonutShop
│
├── Controls
│ ├── CoffeeControl.cs
│ ├── CoffeeControl.Designer.cs
│ ├── DonutControl.cs
│ ├── DonutControl.Designer.cs
│ ├── DonutNumericUpDown.cs
│ ├── ReceiptControl.cs
│
├── Container.cs
├── Container.Designer.cs
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
│
├── Properties
│ ├── AssemblyInfo.cs
│ ├── Resources.resx
│ ├── Settings.settings
│
└── 25Fall-DonutShop.sln
