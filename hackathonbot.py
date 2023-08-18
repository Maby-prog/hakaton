import logging
from aiogram import Dispatcher, Bot, executor, types
from aiogram.dispatcher import FSMContext
from aiogram.contrib.fsm_storage.memory import MemoryStorage
from aiogram.dispatcher.filters.state import State, StatesGroup


API = '5821224794:AAEci9qmrNARgc-lEjqhuCPUg5lxOCJwdq4'


bot = Bot(token=API)
storage = MemoryStorage()
dp = Dispatcher(bot, storage=storage)


class Menu(StatesGroup):
    STEP0 = State()
    STEP1 = State()
    STEP2 = State()
    STEP3 = State()
    STEP4 = State()


students_group_1 = {'Иванов': 'but1', 'Петров': 'but2', 'Ковальков': 'but3'}
students_group_2 = {'Панина': 'but4', 'Кубрак': 'but5', 'Багратунян': 'but6'}
 

@dp.message_handler(commands=['start'])
async def start(message: types.Message):
    chat_id = message.chat.id
    keyboard = types.InlineKeyboardMarkup()
    start = types.InlineKeyboardButton(text='Начать.', callback_data='start')
    name = message.chat.first_name
    keyboard.add(start)
    await message.reply(text=f'Здравствуйте, {name}! Чтобы начать нажмите кнопку ниже.', reply_markup=keyboard)
    await Menu.STEP0.set()


@dp.callback_query_handler(state=Menu.STEP2)
async def menu_step_2(callback: types.CallbackQuery):
    data = callback.data
    chat_id = callback.message.chat.id
    if data == 'but1':
        await bot.send_message(chat_id=chat_id, text=f'''
Успеваемость ученика на данный момент:
Программирование Python: 4
Моушн-дизайн: 4
Графический дизайн: 4
Программирование C#: 4
Разработка игр (Unity): 4''')        
    elif data == 'but2':
        await bot.send_message(chat_id=chat_id, text=f'''
Успеваемость ученика на данный момент:
Программирование Python: 5
Моушн-дизайн: 4
Графический дизайн: 5
Программирование C#: 4
Разработка игр (Unity): 5''')
    elif data == 'but3':
        await bot.send_message(chat_id=chat_id, text=f'''
Успеваемость ученика на данный момент:
Программирование Python: 5
Моушн-дизайн: 4
Графический дизайн: 4
Программирование C#: 5
Разработка игр (Unity): 5''')  
    elif data == 'but7':
        await Menu.STEP1.set()
        await event(callback)
    

@dp.callback_query_handler(state=Menu.STEP3)
async def menu_step_3(callback: types.CallbackQuery):
    data = callback.data
    chat_id = callback.message.chat.id
    if data == 'but4':
        await bot.send_message(chat_id=chat_id, text=f'''
Успеваемость ученика на данный момент:
Программирование Python: 4
Моушн-дизайн: 5
Графический дизайн: 5
Программирование C#: 5
Разработка игр (Unity): 5''')        
    elif data == 'but5':
        await bot.send_message(chat_id=chat_id, text=f'''
Успеваемость ученика на данный момент:
Программирование Python: 4
Моушн-дизайн: 5
Графический дизайн: 5
Программирование C#: 4
Разработка игр (Unity): 4 ''')
    elif data == 'but6':
        await bot.send_message(chat_id=chat_id, text=f'''
Успеваемость ученика на данный момент:
Программирование Python: 5
Моушн-дизайн: 5
Графический дизайн: 5
Программирование C#: 4
Разработка игр (Unity): 4''')
    elif data == 'but8':
        await Menu.STEP1.set()
        await event(callback)
        

@dp.callback_query_handler(state=Menu.STEP4)
async def menu_step_3(callback: types.CallbackQuery):
    data = callback.data
    chat_id = callback.message.chat.id
    if data == 'but1':
        students_group_1.pop('Иванов')
        await bot.send_message(chat_id=chat_id, text='Ученик отчислен.')
        await Menu.STEP1.set()
        await event(callback)
    elif data == 'but2':
        students_group_1.pop('Петров')
        await bot.send_message(chat_id=chat_id, text='Ученик отчислен.')
        await Menu.STEP1.set()
        await event(callback)
    elif data == 'but3':
        students_group_1.pop('Ковальков')
        await bot.send_message(chat_id=chat_id, text='Ученик отчислен.')
        await Menu.STEP1.set()
        await event(callback)
    elif data == 'but4':
        students_group_2.pop('Панина')
        await bot.send_message(chat_id=chat_id, text='Ученик отчислен.')
        await Menu.STEP1.set()
        await event(callback)
    elif data == 'but5':
        students_group_2.pop('Кубрак')
        await bot.send_message(chat_id=chat_id, text='Ученик отчислен.')
        await Menu.STEP1.set()
        await event(callback)
    elif data == 'but6':
        students_group_2.pop('Багратунян')
        await bot.send_message(chat_id=chat_id, text='Ученик отчислен.')
        await Menu.STEP1.set()
        await event(callback)
    elif data == 'but9':
        await Menu.STEP1.set()
        await event(callback)
        
        
@dp.callback_query_handler(state=Menu.STEP1)
async def menu_step_1(callback: types.CallbackQuery):
    data = callback.data
    if data == 'group1':
        await Menu.STEP2.set()
        await event_step_2(callback)
    elif data == 'group2':
        await Menu.STEP3.set()
        await event_step_3(callback)
    elif data == 'delbut0':
        await Menu.STEP4.set()
        await event_step_4(callback)


@dp.callback_query_handler(state=Menu.STEP0)
async def event_0(callback: types.CallbackQuery):
    data = callback.data
    if data == 'start':
        await Menu.STEP1.set()
        await event(callback)


async def event(callback: types.CallbackQuery):
    chat_id = callback.message.chat.id
    keyboard = types.InlineKeyboardMarkup(row_width=2)
    group1 = types.InlineKeyboardButton(text='Группа 1', callback_data='group1')
    group2 = types.InlineKeyboardButton(text='Группа 2', callback_data='group2')
    delbut0 = types.InlineKeyboardButton(text='Отчисление', callback_data='delbut0')
    keyboard.add(group1, group2, delbut0)
    await bot.send_message(chat_id=chat_id, text="Выберите группу или отчисление", reply_markup=keyboard)
    await Menu.STEP1.set()


async def event_step_2(callback: types.CallbackQuery):
    chat_id = callback.message.chat.id
    keyboard = types.InlineKeyboardMarkup(row_width=2)
    but7 = types.InlineKeyboardButton(text='Назад', callback_data='but7')
    for button_name, callback_data in students_group_1.items():
        button = types.KeyboardButton(text=button_name, callback_data=callback_data)
        keyboard.add(button)
    keyboard.add(but7)
    await bot.send_message(chat_id=chat_id, text='Выберите ученика.', reply_markup=keyboard)
    await Menu.STEP2.set()


async def event_step_3(callback: types.CallbackQuery):
    chat_id = callback.message.chat.id
    keyboard = types.InlineKeyboardMarkup(row_width=2)
    but8 = types.InlineKeyboardButton(text='Назад', callback_data='but8')
    for button_name, callback_data in students_group_2.items():
        button = types.KeyboardButton(text=button_name, callback_data=callback_data)
        keyboard.add(button)
    keyboard.add(but8)
    await bot.send_message(chat_id=chat_id, text='Выберите ученика.', reply_markup=keyboard)
    await Menu.STEP3.set()


async def event_step_4(callback: types.CallbackQuery):
    chat_id = callback.message.chat.id
    keyboard = types.InlineKeyboardMarkup()
    but9 = types.InlineKeyboardButton(text='Назад', callback_data='but9')
    for button_name, callback_data in students_group_1.items():
        button = types.KeyboardButton(text=button_name, callback_data=callback_data)
        keyboard.add(button)
    for button_name, callback_data in students_group_2.items():
        button = types.KeyboardButton(text=button_name, callback_data=callback_data)
        keyboard.add(button)
    keyboard.add(but9)
    await bot.send_message(chat_id=chat_id, text='Выберите ученика на отчисение.', reply_markup=keyboard)
    await Menu.STEP4.set()


if __name__ == '__main__':
    logging.basicConfig(level=logging.INFO)
    executor.start_polling(dp, skip_updates=True)