// Подія - це механіхми, який дозволяє об'єктам повідомляти інші об'єкти про те, що щось сталось

// Подія - це ситуація, при виникненні якої виконається дія(метод) або деілька дій(методів)

// Видавець - це об'єкт, який оголошує подію
// Підписник - це об'єкт, який підписується на подію видавця

using _29_Events;

Counter counter = new Counter(); // Publisher
Handler1 handler1 = new Handler1(); // Subscriber
Handler2 handler2 = new Handler2();
Handler3 handler3 = new Handler3();
counter.eventCount += handler1.Message;
counter.eventCount += handler2.Message;
counter.eventCount += handler3.Message;

counter.Count();