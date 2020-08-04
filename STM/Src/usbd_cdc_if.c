/**
  ******************************************************************************
  * @file           : usbd_cdc_if.c
  * @version        : v1.0_Cube
  * @brief          : Usb device for Virtual Com Port.
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

/* Includes ------------------------------------------------------------------*/
#include "usbd_cdc_if.h"
#include "tim.h"
#include "stepperdef.h"

uint32_t per;

/* USER CODE BEGIN INCLUDE */

/* USER CODE END INCLUDE */

/* Private typedef -----------------------------------------------------------*/
/* Private define ------------------------------------------------------------*/
/* Private macro -------------------------------------------------------------*/

/* USER CODE BEGIN PV */
/* Private variables ---------------------------------------------------------*/

/* USER CODE END PV */

/** @addtogroup STM32_USB_OTG_DEVICE_LIBRARY
  * @brief Usb device library.
  * @{
  */

/** @addtogroup USBD_CDC_IF
  * @{
  */

/** @defgroup USBD_CDC_IF_Private_TypesDefinitions USBD_CDC_IF_Private_TypesDefinitions
  * @brief Private types.
  * @{
  */

/* USER CODE BEGIN PRIVATE_TYPES */

/* USER CODE END PRIVATE_TYPES */

/**
  * @}
  */

/** @defgroup USBD_CDC_IF_Private_Defines USBD_CDC_IF_Private_Defines
  * @brief Private defines.
  * @{
  */

/* USER CODE BEGIN PRIVATE_DEFINES */
/* Define size for the receive and transmit buffer over CDC */
/* It's up to user to redefine and/or remove those define */
#define APP_RX_DATA_SIZE  2048
#define APP_TX_DATA_SIZE  2048
/* USER CODE END PRIVATE_DEFINES */

/**
  * @}
  */

/** @defgroup USBD_CDC_IF_Private_Macros USBD_CDC_IF_Private_Macros
  * @brief Private macros.
  * @{
  */

/* USER CODE BEGIN PRIVATE_MACRO */

/* USER CODE END PRIVATE_MACRO */

/**
  * @}
  */

/** @defgroup USBD_CDC_IF_Private_Variables USBD_CDC_IF_Private_Variables
  * @brief Private variables.
  * @{
  */
/* Create buffer for reception and transmission           */
/* It's up to user to redefine and/or remove those define */
/** Received data over USB are stored in this buffer      */
uint8_t UserRxBufferFS[APP_RX_DATA_SIZE];

/** Data to send over USB CDC are stored in this buffer   */
uint8_t UserTxBufferFS[APP_TX_DATA_SIZE];

/* USER CODE BEGIN PRIVATE_VARIABLES */

/* USER CODE END PRIVATE_VARIABLES */

/**
  * @}
  */

/** @defgroup USBD_CDC_IF_Exported_Variables USBD_CDC_IF_Exported_Variables
  * @brief Public variables.
  * @{
  */

extern USBD_HandleTypeDef hUsbDeviceFS;

/* USER CODE BEGIN EXPORTED_VARIABLES */

/* USER CODE END EXPORTED_VARIABLES */

/**
  * @}
  */

/** @defgroup USBD_CDC_IF_Private_FunctionPrototypes USBD_CDC_IF_Private_FunctionPrototypes
  * @brief Private functions declaration.
  * @{
  */

static int8_t CDC_Init_FS(void);
static int8_t CDC_DeInit_FS(void);
static int8_t CDC_Control_FS(uint8_t cmd, uint8_t* pbuf, uint16_t length);
static int8_t CDC_Receive_FS(uint8_t* pbuf, uint32_t *Len);

/* USER CODE BEGIN PRIVATE_FUNCTIONS_DECLARATION */

/* USER CODE END PRIVATE_FUNCTIONS_DECLARATION */

/**
  * @}
  */

USBD_CDC_ItfTypeDef USBD_Interface_fops_FS =
{
  CDC_Init_FS,
  CDC_DeInit_FS,
  CDC_Control_FS,
  CDC_Receive_FS
};

/* Private functions ---------------------------------------------------------*/
/**
  * @brief  Initializes the CDC media low layer over the FS USB IP
  * @retval USBD_OK if all operations are OK else USBD_FAIL
  */
static int8_t CDC_Init_FS(void)
{
  /* USER CODE BEGIN 3 */
  /* Set Application Buffers */
  USBD_CDC_SetTxBuffer(&hUsbDeviceFS, UserTxBufferFS, 0);
  USBD_CDC_SetRxBuffer(&hUsbDeviceFS, UserRxBufferFS);
  return (USBD_OK);
  /* USER CODE END 3 */
}

/**
  * @brief  DeInitializes the CDC media low layer
  * @retval USBD_OK if all operations are OK else USBD_FAIL
  */
static int8_t CDC_DeInit_FS(void)
{
  /* USER CODE BEGIN 4 */
  return (USBD_OK);
  /* USER CODE END 4 */
}

/**
  * @brief  Manage the CDC class requests
  * @param  cmd: Command code
  * @param  pbuf: Buffer containing command data (request parameters)
  * @param  length: Number of data to be sent (in bytes)
  * @retval Result of the operation: USBD_OK if all operations are OK else USBD_FAIL
  */
static int8_t CDC_Control_FS(uint8_t cmd, uint8_t* pbuf, uint16_t length)
{
  /* USER CODE BEGIN 5 */
  switch(cmd)
  {
    case CDC_SEND_ENCAPSULATED_COMMAND:

    break;

    case CDC_GET_ENCAPSULATED_RESPONSE:

    break;

    case CDC_SET_COMM_FEATURE:

    break;

    case CDC_GET_COMM_FEATURE:

    break;

    case CDC_CLEAR_COMM_FEATURE:

    break;

  /*******************************************************************************/
  /* Line Coding Structure                                                       */
  /*-----------------------------------------------------------------------------*/
  /* Offset | Field       | Size | Value  | Description                          */
  /* 0      | dwDTERate   |   4  | Number |Data terminal rate, in bits per second*/
  /* 4      | bCharFormat |   1  | Number | Stop bits                            */
  /*                                        0 - 1 Stop bit                       */
  /*                                        1 - 1.5 Stop bits                    */
  /*                                        2 - 2 Stop bits                      */
  /* 5      | bParityType |  1   | Number | Parity                               */
  /*                                        0 - None                             */
  /*                                        1 - Odd                              */
  /*                                        2 - Even                             */
  /*                                        3 - Mark                             */
  /*                                        4 - Space                            */
  /* 6      | bDataBits  |   1   | Number Data bits (5, 6, 7, 8 or 16).          */
  /*******************************************************************************/
    case CDC_SET_LINE_CODING:

    break;

    case CDC_GET_LINE_CODING:

    break;

    case CDC_SET_CONTROL_LINE_STATE:

    break;

    case CDC_SEND_BREAK:

    break;

  default:
    break;
  }

  return (USBD_OK);
  /* USER CODE END 5 */
}

/**
  * @brief  Data received over USB OUT endpoint are sent over CDC interface
  *         through this function.
  *
  *         @note
  *         This function will block any OUT packet reception on USB endpoint
  *         untill exiting this function. If you exit this function before transfer
  *         is complete on CDC interface (ie. using DMA controller) it will result
  *         in receiving more data while previous ones are still not sent.
  *
  * @param  Buf: Buffer of data to be received
  * @param  Len: Number of data received (in bytes)
  * @retval Result of the operation: USBD_OK if all operations are OK else USBD_FAIL
  */
static int8_t CDC_Receive_FS(uint8_t* Buf, uint32_t *Len)
{
  /* USER CODE BEGIN 6 */
  USBD_CDC_SetRxBuffer(&hUsbDeviceFS, &Buf[0]);
  USBD_CDC_ReceivePacket(&hUsbDeviceFS);
	CDC_ReciveCallBack(Buf, Len[0]);
  return (USBD_OK);
  /* USER CODE END 6 */
}

/**
  * @brief  CDC_Transmit_FS
  *         Data to send over USB IN endpoint are sent over CDC interface
  *         through this function.
  *         @note
  *
  *
  * @param  Buf: Buffer of data to be sent
  * @param  Len: Number of data to be sent (in bytes)
  * @retval USBD_OK if all operations are OK else USBD_FAIL or USBD_BUSY
  */
uint8_t CDC_Transmit_FS(uint8_t* Buf, uint16_t Len)
{
  uint8_t result = USBD_OK;
  USBD_CDC_HandleTypeDef *hcdc = (USBD_CDC_HandleTypeDef*)hUsbDeviceFS.pClassData;
  if (hcdc->TxState != 0){
    return USBD_BUSY;
  }
  USBD_CDC_SetTxBuffer(&hUsbDeviceFS, Buf, Len);
  result = USBD_CDC_TransmitPacket(&hUsbDeviceFS);
  return result;
}

__weak void CDC_ReciveCallBack(uint8_t *buff, uint32_t len)
{
	if(buff[len-1] == '\n')
	{
		switch ((uint8_t)buff[0])
			{
				case 65:
					if(calib == true)
					{
						stepperA.steps = 0;
						stepperB.steps = 0;
						stepperC.steps = 0;
						HAL_GPIO_WritePin(LS_A_OUT_GPIO_Port, LS_A_OUT_Pin, GPIO_PIN_SET);
						HAL_GPIO_WritePin(LS_B_OUT_GPIO_Port, LS_B_OUT_Pin, GPIO_PIN_SET);
						HAL_GPIO_WritePin(LS_C_OUT_GPIO_Port, LS_C_OUT_Pin, GPIO_PIN_SET);
					}
						
					stepperA.dir = buff[1] - 48;
					stepperB.dir = buff[15] - 48;
					stepperC.dir = buff[29] - 48;
				
					for (int i = 8; i < 14; i++)
					{
						stepperA.steps = stepperA.steps + pow(10, 13 - i)*(buff[i] - 48);
					}
					for (int i = 22; i < 28; i++)
					{
						stepperB.steps = stepperB.steps + pow(10, 27 - i)*(buff[i] - 48);
					}
					for (int i = 36; i < 42; i++)
					{
						stepperC.steps = stepperC.steps + pow(10, 41 - i)*(buff[i] - 48);
					}
					
					per = 0;
					for (int i = 2; i < 8; i++)
					{
						per = per + pow(10, 7 - i)*(buff[i] - 48);
					}
					if(per != stepperA.periodps)
					{
						stepperA.periodps = per;
						MX_TIM5_Init();
						htim5.Instance->CCR3 = 50;
					}
					
					per = 0;
					for (int i = 16; i < 22; i++)
					{
						per = per + pow(10, 21 - i)*(buff[i] - 48);
					}
					if(per != stepperB.periodps)
					{
						stepperB.periodps = per;
						MX_TIM2_Init();
						htim2.Instance->CCR1 = 50;
					}
					
					per = 0;
					for (int i = 30; i < 36; i++)
					{
						per = per + pow(10, 35 - i)*(buff[i] - 48);
					}
					if(per != stepperC.periodps)
					{
						stepperC.periodps = per;
						MX_TIM3_Init();
						htim3.Instance->CCR3 = 50;
					}					
					memset(&buff, 0, sizeof(buff));
					stepperA.dir == 0 ? HAL_GPIO_WritePin(DRV_A_DIR_GPIO_Port, DRV_A_DIR_Pin, GPIO_PIN_SET) : HAL_GPIO_WritePin(DRV_A_DIR_GPIO_Port, DRV_A_DIR_Pin, GPIO_PIN_RESET);
					stepperB.dir == 0 ? HAL_GPIO_WritePin(DRV_B_DIR_GPIO_Port, DRV_B_DIR_Pin, GPIO_PIN_RESET) : HAL_GPIO_WritePin(DRV_B_DIR_GPIO_Port, DRV_B_DIR_Pin, GPIO_PIN_SET);
					stepperC.dir == 0 ? HAL_GPIO_WritePin(DRV_C_DIR_GPIO_Port, DRV_C_DIR_Pin, GPIO_PIN_RESET) : HAL_GPIO_WritePin(DRV_C_DIR_GPIO_Port, DRV_C_DIR_Pin, GPIO_PIN_SET);
					if (stepperA.steps > 0)
						HAL_TIM_PWM_Start_IT(&htim5, TIM_CHANNEL_3);
					if (stepperB.steps > 0)
						HAL_TIM_PWM_Start_IT(&htim2, TIM_CHANNEL_1);
					if (stepperC.steps > 0)
						HAL_TIM_PWM_Start_IT(&htim3, TIM_CHANNEL_3);
					if (stepperA.steps == 0 && stepperB.steps == 0 && stepperC.steps == 0)
						CDC_Transmit_FS((uint8_t*)stop, 5);
					else
					{
						if(calib == false)
							HAL_TIM_Base_Start_IT(&htim4);
						else;
					}					
					break;
				case 67:
					memset(&buff, 0, sizeof(buff));
					stepperA.steps = 0;
					stepperB.steps = 0;
					stepperC.steps = 0;
					calib = true;
					CDC_Transmit_FS((uint8_t*)C1, 2);
					break;
				case 68:
					if(buff[len-2] == 'N')
					{
						HAL_GPIO_WritePin(RELAY_2_GPIO_Port, RELAY_2_Pin, GPIO_PIN_SET); // turn on DC motor
						//HAL_GPIO_WritePin(BUZZER_GPIO_Port, BUZZER_Pin, GPIO_PIN_RESET); // turn off buzzer
					}
					else
					{
						HAL_GPIO_WritePin(RELAY_2_GPIO_Port, RELAY_2_Pin, GPIO_PIN_RESET); // turn off DC motor
						//HAL_GPIO_WritePin(BUZZER_GPIO_Port, BUZZER_Pin, GPIO_PIN_SET); // turn on buzzer
					}
					memset(&buff, 0, sizeof(buff));
					break;
				case 79: // OK, Start timers and Config Direction Pins
					memset(&buff, 0, sizeof(buff));
					stepperA.dir == 0 ? HAL_GPIO_WritePin(DRV_A_DIR_GPIO_Port, DRV_A_DIR_Pin, GPIO_PIN_SET) : HAL_GPIO_WritePin(DRV_A_DIR_GPIO_Port, DRV_A_DIR_Pin, GPIO_PIN_RESET);
					stepperB.dir == 0 ? HAL_GPIO_WritePin(DRV_B_DIR_GPIO_Port, DRV_B_DIR_Pin, GPIO_PIN_RESET) : HAL_GPIO_WritePin(DRV_B_DIR_GPIO_Port, DRV_B_DIR_Pin, GPIO_PIN_SET);
					stepperC.dir == 0 ? HAL_GPIO_WritePin(DRV_C_DIR_GPIO_Port, DRV_C_DIR_Pin, GPIO_PIN_RESET) : HAL_GPIO_WritePin(DRV_C_DIR_GPIO_Port, DRV_C_DIR_Pin, GPIO_PIN_SET);
					if (stepperA.steps > 0)
					{
						HAL_TIM_PWM_Start_IT(&htim5, TIM_CHANNEL_3);
					}						
					if (stepperB.steps > 0)
					{
						HAL_TIM_PWM_Start_IT(&htim2, TIM_CHANNEL_1);
					}
					if (stepperC.steps > 0)
					{
						HAL_TIM_PWM_Start_IT(&htim3, TIM_CHANNEL_3);
					}
					if (stepperA.steps == 0 && stepperB.steps == 0 && stepperC.steps == 0)
						CDC_Transmit_FS((uint8_t*)stop, 5);
					else
					{
						HAL_GPIO_WritePin(LED_R_GPIO_Port, LED_R_Pin, GPIO_PIN_RESET);
						if(calib == false)
							HAL_TIM_Base_Start_IT(&htim4);
						else;
					}					
					break;
				case 80: // PAUSE
					memset(&buff, 0, sizeof(buff));
					HAL_TIM_PWM_Stop(&htim5, TIM_CHANNEL_3);
					HAL_TIM_PWM_Stop(&htim2, TIM_CHANNEL_1);
					HAL_TIM_PWM_Stop(&htim3, TIM_CHANNEL_3);
					HAL_TIM_Base_Stop(&htim4);	
					HAL_GPIO_WritePin(LED_R_GPIO_Port, LED_R_Pin, GPIO_PIN_SET);		
					CvtCurSteps(PAUSE, stepperA.steps, stepperB.steps, stepperC.steps, (uint8_t *)buffF);
					CDC_Transmit_FS((uint8_t *)buffF, 20);	
					break;
				case 83: // STOP
					memset(&buff, 0, sizeof(buff));
					HAL_TIM_PWM_Stop(&htim5, TIM_CHANNEL_3);
					HAL_TIM_PWM_Stop(&htim2, TIM_CHANNEL_1);
					HAL_TIM_PWM_Stop(&htim3, TIM_CHANNEL_3);
					HAL_TIM_Base_Stop(&htim4);	
					HAL_GPIO_WritePin(LED_R_GPIO_Port, LED_R_Pin, GPIO_PIN_SET);			
					CvtCurSteps(PAUSE, stepperA.steps, stepperB.steps, stepperC.steps, (uint8_t *)buffF);
					CDC_Transmit_FS((uint8_t *)buffF, 20);
					stepperA.steps = 0;
					stepperB.steps = 0;
					stepperC.steps = 0;
					break;
			}
		}
		else
		{
			//
		}
}

/* USER CODE BEGIN PRIVATE_FUNCTIONS_IMPLEMENTATION */

/* USER CODE END PRIVATE_FUNCTIONS_IMPLEMENTATION */

/**
  * @}
  */

/**
  * @}
  */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
