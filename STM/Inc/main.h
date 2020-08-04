/**
  ******************************************************************************
  * @file           : main.h
  * @brief          : Header for main.c file.
  *                   This file contains the common defines of the application.
  ******************************************************************************
  * This notice applies to any and all portions of this file
  * that are not between comment pairs USER CODE BEGIN and
  * USER CODE END. Other portions of this file, whether 
  * inserted by the user or by software development tools
  * are owned by their respective copyright owners.
  *
  * Copyright (c) 2020 STMicroelectronics International N.V. 
  * All rights reserved.
  *
  * Redistribution and use in source and binary forms, with or without 
  * modification, are permitted, provided that the following conditions are met:
  *
  * 1. Redistribution of source code must retain the above copyright notice, 
  *    this list of conditions and the following disclaimer.
  * 2. Redistributions in binary form must reproduce the above copyright notice,
  *    this list of conditions and the following disclaimer in the documentation
  *    and/or other materials provided with the distribution.
  * 3. Neither the name of STMicroelectronics nor the names of other 
  *    contributors to this software may be used to endorse or promote products 
  *    derived from this software without specific written permission.
  * 4. This software, including modifications and/or derivative works of this 
  *    software, must execute solely and exclusively on microcontroller or
  *    microprocessor devices manufactured by or for STMicroelectronics.
  * 5. Redistribution and use of this software other than as permitted under 
  *    this license is void and will automatically terminate your rights under 
  *    this license. 
  *
  * THIS SOFTWARE IS PROVIDED BY STMICROELECTRONICS AND CONTRIBUTORS "AS IS" 
  * AND ANY EXPRESS, IMPLIED OR STATUTORY WARRANTIES, INCLUDING, BUT NOT 
  * LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
  * PARTICULAR PURPOSE AND NON-INFRINGEMENT OF THIRD PARTY INTELLECTUAL PROPERTY
  * RIGHTS ARE DISCLAIMED TO THE FULLEST EXTENT PERMITTED BY LAW. IN NO EVENT 
  * SHALL STMICROELECTRONICS OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
  * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
  * LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
  * OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF 
  * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
  * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE,
  * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
  *
  ******************************************************************************
  */

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MAIN_H__
#define __MAIN_H__

/* Includes ------------------------------------------------------------------*/

/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Private define ------------------------------------------------------------*/

#define DRV_A_RST_Pin GPIO_PIN_0
#define DRV_A_RST_GPIO_Port GPIOC
#define DRV_A_DIR_Pin GPIO_PIN_2
#define DRV_A_DIR_GPIO_Port GPIOC
#define BUTTON_Pin GPIO_PIN_0
#define BUTTON_GPIO_Port GPIOA
#define DRV_A_STP_Pin GPIO_PIN_2
#define DRV_A_STP_GPIO_Port GPIOA 
#define DRV_B_DIR_Pin GPIO_PIN_3
#define DRV_B_DIR_GPIO_Port GPIOA
#define DRV_B_STP_Pin GPIO_PIN_5
#define DRV_B_STP_GPIO_Port GPIOA
#define DRV_B_RST_Pin GPIO_PIN_7
#define DRV_B_RST_GPIO_Port GPIOA
#define DRV_C_STP_Pin GPIO_PIN_0
#define DRV_C_STP_GPIO_Port GPIOB
#define DRV_C_DIR_Pin GPIO_PIN_15
#define DRV_C_DIR_GPIO_Port GPIOE
#define DRV_C_RST_Pin GPIO_PIN_9
#define DRV_C_RST_GPIO_Port GPIOD
#define LED_G_Pin GPIO_PIN_12
#define LED_G_GPIO_Port GPIOD
#define LED_O_Pin GPIO_PIN_13
#define LED_O_GPIO_Port GPIOD
#define LED_R_Pin GPIO_PIN_14
#define LED_R_GPIO_Port GPIOD
#define LED_B_Pin GPIO_PIN_15
#define LED_B_GPIO_Port GPIOD
#define BUZZER_Pin GPIO_PIN_7
#define BUZZER_GPIO_Port GPIOC
#define LS_A_OUT_Pin GPIO_PIN_0
#define LS_A_OUT_GPIO_Port GPIOD
#define LS_A_IN_Pin GPIO_PIN_2
#define LS_A_IN_GPIO_Port GPIOD
#define LS_B_OUT_Pin GPIO_PIN_4
#define LS_B_OUT_GPIO_Port GPIOD
#define LS_B_IN_Pin GPIO_PIN_6
#define LS_B_IN_GPIO_Port GPIOD
#define LS_C_OUT_Pin GPIO_PIN_3
#define LS_C_OUT_GPIO_Port GPIOB
#define LS_C_IN_Pin GPIO_PIN_5
#define LS_C_IN_GPIO_Port GPIOB
#define RELAY_1_Pin GPIO_PIN_8
#define RELAY_1_GPIO_Port GPIOB
#define RELAY_2_Pin GPIO_PIN_9
#define RELAY_2_GPIO_Port GPIOB

/* ########################## Assert Selection ############################## */
/**
  * @brief Uncomment the line below to expanse the "assert_param" macro in the 
  *        HAL drivers code
  */
/* #define USE_FULL_ASSERT    1U */

/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
 extern "C" {
#endif
void _Error_Handler(char *, int);

#define Error_Handler() _Error_Handler(__FILE__, __LINE__)
#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H__ */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
