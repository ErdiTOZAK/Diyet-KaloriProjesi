using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using EF_DietaryProject.UI.VMs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DietaryProject.UI
{
    public partial class ReportsForm : Form
    {
        string username;
        public ReportsForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }


        private void ReportsForm_Load(object sender, EventArgs e)
        {
            GetMeals();
            GetMostConsumedFoods();
            GetMostConsumedFoodsByMeal();
            UserInfo();
        }

        private void GetMeals()
        {
            var user = UnitOfWork.Instance.AppUserRepository.GetAll().
                FirstOrDefault(x => x.Username == username);


            List<Dish> dishes = UnitOfWork.Instance.DishRepository.GetAll().Include(x => x.Meal).
                Where(x => x.MealDate.Date == dtpEndDay.Value.Date && x.AppUserDetailId == user.Id)
                .ToList();


            List<DishViewModel> dishViewModels = GetDishViewModels(dishes);


            dgwEndDay.DataSource = dishViewModels;
            dgwEndDay.Columns["Id"].Visible = false;

            float totalCalories = dishes.Sum(x => x.CaloriesTaken);
            txtTotalCalories.Text = totalCalories.ToString();
        }
        private List<DishViewModel> GetDishViewModels(List<Dish> dishes)
        {
            List<DishViewModel> dishViewModels = new List<DishViewModel>();

            foreach (var dish in dishes)
            {
                DishViewModel viewModel = new DishViewModel
                {
                    Id = dish.Id,
                    MealDate = dish.MealDate,
                    CaloriesTaken = dish.CaloriesTaken,
                    MealName = dish.Meal?.Name 
                };

                dishViewModels.Add(viewModel);
            }

            return dishViewModels;
        }

        private void dtpEndDay_ValueChanged(object sender, EventArgs e)
        {
            GetMeals();
        }

        private void GetMostConsumedFoods()
        {
            var user = UnitOfWork.Instance.AppUserRepository.GetAll().
                FirstOrDefault(x => x.Username == username);

            
            var consumedFoods = UnitOfWork.Instance.DishDetailRepository.GetAll()
                .Where(x => x.Dish.MealDate.Date >= dtpStartDate.Value.Date &&
                x.Dish.MealDate.Date <= dtpEndDate.Value.Date && x.Dish.AppUserDetailId == user.Id)
                .GroupBy(x => x.Food.FoodName)
                .Select(g => new
                {
                    FoodName = g.Key,
                    TotalConsumed = g.Sum(x => x.Gramme)
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            
            dgwMostConsumedFoods.DataSource = consumedFoods;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            GetMostConsumedFoods();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            GetMostConsumedFoods();
        }

        private void GetMostConsumedFoodsByMeal()
        {
            var user = UnitOfWork.Instance.AppUserRepository.GetAll().
                FirstOrDefault(x => x.Username == username);

           
            var consumedFoods = UnitOfWork.Instance.DishDetailRepository.GetAll()
                .Where(x => x.Dish.MealDate.Date >= dtpStartByMeal.Value.Date && 
                x.Dish.MealDate.Date <= dtpEndByMeal.Value.Date && x.Dish.AppUserDetailId == user.Id)
                .GroupBy(x => new { x.Food.FoodName, x.Dish.Meal.Name })
                .Select(g => new
                {
                    FoodName = g.Key.FoodName,
                    MealName = g.Key.Name,
                    TotalConsumed = g.Sum(x => x.Gramme)
                })
                .ToList();

            
            dgwMostConsumedFoodsByMeal.DataSource = consumedFoods;
        }

        private void dtpStartByMeal_ValueChanged(object sender, EventArgs e)
        {
            GetMostConsumedFoodsByMeal();
        }

        private void dtpEndByMeal_ValueChanged(object sender, EventArgs e)
        {
            GetMostConsumedFoodsByMeal();
        }


        private void UserInfo()
        {
            var user = UnitOfWork.Instance.AppUserRepository.GetAll().
                FirstOrDefault(x => x.Username == username);
            var userDetail = UnitOfWork.Instance.AppUserDetailRepository.GetAll().
                FirstOrDefault(x => x.AppUserId == user.Id);


            float bmi = CalculateBMI(userDetail);
            

            txtSumFullName.Text = userDetail.Firstname + " " + userDetail.Lastname;
            txtSumWeight.Text = userDetail.Weight.ToString();
            txtSumHeight.Text = userDetail.Height.ToString();
            txtSumAge.Text = userDetail.Age.ToString();
            txtSumBMI.Text = Math.Round(bmi, 2).ToString();
        }

        
        private float CalculateBMI(AppUserDetail? userDetail)
        {
            if (userDetail.Height != 0) 
            {
                float heightInMeter = userDetail.Height / 100.0f; 
                return userDetail.Weight / (heightInMeter * heightInMeter); 
            }
            else
            {
                return 0;
            }
        }

        private void btnGetInformation_Click(object sender, EventArgs e)
        {
            var user = UnitOfWork.Instance.AppUserRepository.GetAll().
                FirstOrDefault(x => x.Username == username);
            var userDetail = UnitOfWork.Instance.AppUserDetailRepository.GetAll().
                FirstOrDefault(x => x.AppUserId == user.Id);

            if (userDetail != null)
            {
                float bmi = CalculateBMI(userDetail);
                CheckTargetCompatibility(bmi, userDetail);
            }
            else
            {
                MessageBox.Show("User details not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckTargetCompatibility(float bmi, AppUserDetail userDetail)
        {
            var target = UnitOfWork.Instance.TargetRepository.GetById((int)userDetail.TargetId);
            if (target != null)
            {
                if (bmi < 18.5 && target.Id == 1) 
                {
                    MessageBox.Show("Your weight is in the underweight category. " +
                        "You need to gain weight.Your target 'Lose Weight' is not inline " +
                        "with your weight category" +
                        ". Please revise your target.", 
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (bmi < 18.5 && target.Id == 2) 
                {
                    MessageBox.Show("Your weight is in the underweight category. " +
                        "You need to gain weight. Your target 'Maintain Weight' " +
                        "is not inline with your" +
                        ". Please revise your target.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (bmi < 18.5 && target.Id == 3)
                {
                    MessageBox.Show("Your weight is in the underweight category. " +
                        "You need to gain weight.Your target 'Gain Weight' is inline " +
                        "with your weight category " +
                        ".", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else if (bmi >= 18.5 && bmi < 24.9 && target.Id == 1) 
                {
                    MessageBox.Show("Your weight is within the healthy weight category. " +
                        "You need to maintain your weight. Your target 'lose Weight' " +
                        "is not inline with your weight category. . Please revise your target.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (bmi >= 18.5 && bmi < 24.9 && target.Id == 2) 
                {
                    MessageBox.Show("Your weight is within the healthy weight category. " +
                        "You need to maintain your weight. Your target 'Gain Weight' " +
                        "is inline with your weight category..", "Warning", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
                else if (bmi >= 18.5 && bmi < 24.9 && target.Id == 3)
                {
                    MessageBox.Show("Your weight is within the healthy weight category. " +
                        "You need to maintain your weight. Your target 'Gain Weight' " +
                        "is not inline with weight category. Please revise your target." , 
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (bmi >= 24.9 && target.Id == 1) 
                {
                    MessageBox.Show("Your weight is in the obese category." +
                        " Your target 'lose weight' is inline with your weight " +
                        "category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (bmi >= 24.9 && target.Id == 2) 
                {
                    MessageBox.Show("Your weight is in the obese category. " +
                        "You need to lose weight.Your target 'maintain weight' " +
                        "is not inline with your weight category " +
                        "Please revise your target.", "Warning", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (bmi >= 24.9 && target.Id == 3)
                {
                    MessageBox.Show("Your weight is in the obese category. " +
                        "You need to lose weight.You are overwight according " +
                        "to your target 'Gain Weight'. Please revise your target.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

    }
}
        
